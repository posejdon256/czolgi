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
using System.Windows.Shapes;

namespace Czolgi.Menu_Items
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        #region public methods
        /// <summary>
        /// Pokazuje XAMLa z instrukcjami
        /// </summary>
        public void ShowInstructions()
        { }
        /// <summary>
        /// Pokazuje XAMLa z Best Scores
        /// </summary>
        public void ShowBestScores()
        { }
        /// <summary>
        /// Wyłącza grę
        /// </summary>
        public void TurnOff()
        { }
        /// <summary>
        /// Otwera XAMLa z ustawieniami
        /// </summary>
        public void StartSettings()
        { }
        /// <summary>
        /// Rozpoczyna grę
        /// </summary>
        public void StartGame()
        { }
        #endregion
    }
}
