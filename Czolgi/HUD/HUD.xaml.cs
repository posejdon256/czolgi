using System;
using System.Windows.Controls;
using IndividualProjectClasses.Objects.Enemy;

namespace HUD
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        #region private fields

        private Int32 Score { get; set; }
        private Int16 Lives { get; set; }
        private WrogiCzolg Enemys { get; set; }
        private bool Pause { get; set; }
        private bool Sound { get; set; }
        
        #endregion
        public UserControl1()
        {
            InitializeComponent();
        }
        #region public methods

        /// <summary>
        /// Poprawia wynik o "pointsToAdd"
        /// </summary>
        /// <param name="pointsToAdd"></param>
        public void AddPoints(int pointsToAdd)
        { }
        /// <summary>
        /// Powiększa liczbę żyć użytkownika o 1
        /// </summary>
        /// <param name="lifestToAdd"></param>
        public void AddLifes(int lifestToAdd = 1)
        { }
        /// <summary>
        /// Zmniejsza liczbę żyć użytkownika o lufeToRemove
        /// </summary>
        /// <param name="lifeToRemove"></param>
        public void RemoveLifes(int lifeToRemove = 1)
        { }
        /// <summary>
        /// Włącza, wyłącza muzykę
        /// </summary>
        /// <param name="music"></param>
        public void TurnOnOffMusic(bool music)
        { }
        /// <summary>
        /// Włącza lub wyłącza grę
        /// </summary>
        /// <param name="pause"></param>
        public void TurnOnOffGame(bool pause)
        { }
        #endregion
    }
}
