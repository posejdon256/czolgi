using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Czolgi.Controllers;
using IndividualProjectClasses.Objects;
using System.Threading;
using System.Windows.Media.Animation;
using IndividualProjectClasses.Helpers;

namespace Czolgi.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Game : Window
    {
        private Image[,] images = new Image[39,39];
        private Element[,] elements = null;
        private List<Czolg> tanksList = new List<Czolg>();
        private List<Shot> shots = new List<Shot>();
        private Czolg tank;
        private int level = 0;
        private int points = 0;
        private MediaPlayer MediaPlayer = new MediaPlayer();
        private Dictionary<string, UIElement> HUDelements = new Dictionary<string, UIElement>();
        private string[][] settings;
        public Game()
        {
            InitializeComponent();
            settings = FileHelper.GetSettings();
            StartGame();
            MediaPlayer.Open(new Uri("Resources\\MenuBackground.mp3", UriKind.Relative));
            if (settings[1][5] == "tak")
                MediaPlayer.Play();
            else
              (HUDelements["music"] as CheckBox).IsChecked = false;
        }

        private void GameInProgres()
        {
            //HARDCODED
            EnemyTankController.FillTanks(0);
            int i = 0;
            while (true)
            {
                
                List<int[]> pointsToUpdate = UpdateElements.ImagesToUpdate(ref elements, ref tanksList, ref shots, ref points);
                foreach (var point in pointsToUpdate)
                {
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        if (point[1] >= 18 && point[1] <= 20 && point[0] >= 36)
                        {
                            EndController.Loose(points, this);
                        }
                        bool isNull = images[point[0], point[1]] == null;
                        if (elements[point[0], point[1]] == null)
                        {
                            gameGrid.Children.Remove(images[point[0], point[1]]);
                            images[point[0], point[1]] = null;
                        }
                        else
                        {
                            images[point[0], point[1]] = ImageController.GetImage(elements[point[0], point[1]],
                                ref tanksList,ref tank, images[point[0], point[1]], false);
                            if (isNull)
                                gameGrid.Children.Add(images[point[0], point[1]]);
                        }
                    }));
                }
              
                this.Dispatcher.Invoke((Action)(() =>
                {
                    bool isNull = images[tank.PosX, tank.PosY] == null;
                    images[tank.PosX, tank.PosY] = ImageController.GetImage(tank,
                                ref tanksList, ref tank, images[tank.PosX, tank.PosY], false);
                    if (isNull)
                        gameGrid.Children.Add(images[tank.PosX, tank.PosY]);
                }));
                if (i == 80)
                {
                    EnemyTankController.AddEnemyTank(ref elements, ref tanksList,level);
                    i = 0;
                }
                this.Dispatcher.Invoke((Action) (() =>
                {
                    (HUDelements["lifes"] as Label).Content = tank.armor + "x";
                    (HUDelements["enemies"] as Label).Content = tanksList.Count + "x";
                    (HUDelements["wynik"] as Label).Content = "Wynik: " + points;
                    if (tank.armor == 0)
                    {
                        //HARDOCODED
                        EndController.Loose(points, this);
                    }
                    if (EnemyTankController.enemyTanksNumber >= 14 && tanksList.Count == 0)
                    {
                        EndController.LoadNextLevel(ref images, ref elements, ref tanksList, ref shots, ref tank,
                            ref gameGrid, ref HUDelements, ((level + 1)%3) + 1);
                        level = ((level + 1)%3) + 1;
                        points += 500;
                    }
                    HUDelements["enemies"].InvalidateVisual();
                    HUDelements["lifes"].InvalidateVisual();
                }));
                i++;
                List<int[]> leafs = LeafController.GetLeafs();
                foreach (var point in leafs)
                {
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        bool isNull = images[point[0], point[1]] == null;
                        images[point[0], point[1]] = LeafController.GetImageLeaf(point[0], point[1]);
                        if (isNull)
                            gameGrid.Children.Add(images[point[0], point[1]]);
                    }));
                }
                Thread.Sleep(100);
            }
        }

        #region public methods
        /// <summary>
        /// To się wydarzy po kliknięciu "StartGame" w Main Menu
        /// </summary>
        public void StartGame()
        {
            EndController.LoadNextLevel(ref images,ref elements, ref tanksList, ref shots, ref tank, ref gameGrid, ref HUDelements,1);
            //HUD
            (HUDelements["music"] as CheckBox).Unchecked += Game_Unchecked;
            (HUDelements["music"] as CheckBox).Checked += Game_Checked;
            //Generacja czołgów
            Thread timerProgress = new Thread(o =>
            {
                Thread.Sleep(1000);
                GameInProgres();
            });
            timerProgress.Start();
        }

        private void Game_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Play();
        }

        private void Game_Unchecked(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
        }

        #endregion

        private void mainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            List<int[]> move = null;
           // if ((Math.Abs((tank.lastMove - DateTime.Now).TotalMilliseconds) >= tank.speed*1000))
                move = KeyController.ClientWantMove(ref tank, ref elements, e, ref tanksList);
            if (move == null)
            {
                Shot shot = KeyController.ClientWantShoot(tank, e);
                if(shot == null)
                    return;
                shots.Add(shot);
                return;
            }
            foreach (var point in move)
            {
                bool isNull = images[point[0], point[1]] == null;
                if (elements[point[0], point[1]] == null)
                {
                    gameGrid.Children.Remove(images[point[0], point[1]]);
                    images[point[0], point[1]] = null;
                }
                else
                {
                    images[point[0], point[1]] = ImageController.GetImage(elements[point[0], point[1]],
                        ref tanksList, ref tank, images[point[0], point[1]], false);
                    if (isNull)
                        gameGrid.Children.Add(images[point[0], point[1]]);
                }
            }
        }

        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
