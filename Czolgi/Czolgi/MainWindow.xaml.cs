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
using Czolgi.View;

namespace Czolgi
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer MediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }
        #region public methods

        /// <summary>
        /// Pokazuje XAMLa z instrukcjami
        /// </summary>
        public void ShowInstructions()
        {
            Instructions instructions = new Instructions();
            instructions.ShowDialog();
        }

        /// <summary>
        /// Pokazuje XAMLa z Best Scores
        /// </summary>
        public void ShowBestScores()
        {
            BestScores bestScores = new BestScores();
            bestScores.ShowDialog();
        }

        /// <summary>
        /// Wyłącza grę
        /// </summary>
        public void TurnOff()
        {
            Close();
        }

        /// <summary>
        /// Otwera XAMLa z ustawieniami
        /// </summary>
        public void StartSettings()
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        /// <summary>
        /// Rozpoczyna grę
        /// </summary>
        public void StartGame()
        {
            Game game = new Game();
            game.ShowDialog();
        }
        #endregion
        #region events
        private void ButtonEnd_OnClick(object sender, RoutedEventArgs e)
        {
            TurnOff();
        }
        private void ButtonScores_OnClick(object sender, RoutedEventArgs e)
        {
            ShowBestScores();
        }
        private void ButtonSettings_OnClick(object sender, RoutedEventArgs e)
        {
            StartSettings();
        }
        private void ButtonPlay_OnClick(object sender, RoutedEventArgs e)
        {
            StartGame();
        }
        private void ButtonInstructions_OnClick(object sender, RoutedEventArgs e)
        {
            ShowInstructions();
        }
        #endregion
    }
}
