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

namespace Czolgi.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Game : Window
    {
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
                cd.Width = new GridLength(1, GridUnitType.Star);
                gameGrid.ColumnDefinitions.Add(cd);

                RowDefinition rd = new RowDefinition();
                rd.Height = new GridLength(1, GridUnitType.Star);
                gameGrid.RowDefinitions.Add(rd);
            }
            for(int i = 0; i < 39; i ++)
            {
                for(int j= 0; j < 39; j ++)
                {
                    Image im = new Image();
                    im.Source = "/Czolgi;component/Resources/arrows.png"
                }
            }
        }
        #endregion
    }
}
