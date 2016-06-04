using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Czolgi.View;
using IndividualProjectClasses.Helpers;
using IndividualProjectClasses.Objects;

namespace Czolgi.Controllers
{
    internal static class EndController
    {
        internal static void LoadNextLevel(ref Image[,] images, ref Element[,] elements, ref List<Czolg> tanksList,
            ref List<Shot> shots, ref Czolg tank, ref Grid gameGrid, ref Dictionary<string, UIElement> HUDelements, int level )
        {
            EnemyTankController.FillTanks(level);
            EnemyTankController.enemyTanksNumber = 0;
            gameGrid.ColumnDefinitions.Clear();
            gameGrid.RowDefinitions.Clear();
            gameGrid.Children.Clear();
            images = new Image[39,39];
            elements = new Element[39,39];
            tanksList.Clear();
            shots.Clear();
            HUDelements = new Dictionary<string, UIElement>();
            tank = new Czolg(37,14,0);
            LeafController.GenerateLeafs();

            RowDefinition rd1 = new RowDefinition();
            rd1.Height = new GridLength(3, GridUnitType.Star);
            gameGrid.RowDefinitions.Add(rd1);

            ColumnDefinition cd1 = new ColumnDefinition();
            cd1.Width = new GridLength(15, GridUnitType.Star);
            gameGrid.ColumnDefinitions.Add(cd1);
            for (int i = 0; i < 39; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(1, GridUnitType.Star);
                gameGrid.ColumnDefinitions.Add(cd);

                RowDefinition rd = new RowDefinition();
                rd.Height = new GridLength(1, GridUnitType.Star);
                gameGrid.RowDefinitions.Add(rd);
            }
            cd1 = new ColumnDefinition();
            cd1.Width = new GridLength(15, GridUnitType.Star);
            gameGrid.ColumnDefinitions.Add(cd1);

            HUDController.GenerateHUD(ref gameGrid, ref HUDelements);

            LoadBoard.LoadElements(ref elements,level);

            for (int i = 0; i < 39; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    if (elements[i, j] != null)
                    {
                        images[i, j] = ImageController.GetImage(elements[i, j], ref tanksList, ref tank);
                        gameGrid.Children.Add(images[i, j]);
                    }

                }
            }
        }

        internal static void Loose(int points, Window mainWindow)
        {
            string[][] scores = FileHelper.GetBestScore();
            List<string[]> helpList = new List<string[]>();
            bool added = false;
            string name = Microsoft.VisualBasic.Interaction.InputBox("Koniec gry", "Podaj swoje imię", "Ania");
            for (int i = 0; i < scores.GetLength(0); i ++)
            {
                if (Int32.Parse(scores[i][1]) < points && !added)
                {
                    helpList.Add(new string[] {name,points.ToString()});
                    added = true;
                }
                helpList.Add(scores[i]);
            }
            if(!added)
                helpList.Add(new string[] { name, points.ToString() });
            FileHelper.SetScores(helpList.ToArray());
            BestScores bs = new BestScores();
            bs.ShowDialog();
            mainWindow.Close();
        }
    }
}
