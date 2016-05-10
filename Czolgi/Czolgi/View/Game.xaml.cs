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

namespace Czolgi.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Game : Window
    {
        private Image[,] images = new Image[39,39];
        private Element[,] elements = null;
        public Game()
        {
            InitializeComponent();
            StartGame();
        }
        #region public methods
        /// <summary>
        /// To się wydarzy po kliknięciu "StartGame" w Main Menu
        /// </summary>
        public void StartGame()
        {
            for (int i = 0; i < 39; i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(20, GridUnitType.Pixel);
                gameGrid.ColumnDefinitions.Add(cd);

                RowDefinition rd = new RowDefinition();
                rd.Height = new GridLength(1, GridUnitType.Star);
                gameGrid.RowDefinitions.Add(rd);
            }
            LoadBoard.LoadElements(ref elements);
            for (int i = 0; i < 39; i++)
            {
                for (int j = 0; j < 39; j++)
                {
                    if (elements[i, j] != null)
                    {
                        images[i, j] = ImageController.GetImage(elements[i, j]);
                        gameGrid.Children.Add(images[i, j]);
                    }
                    
                }
            }
        }

        #endregion
    }
}
