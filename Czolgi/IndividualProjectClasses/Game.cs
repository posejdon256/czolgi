using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProjectClasses.Objects;

namespace IndividualProjectClasses
{
    public class Game
    {
        #region private fields

        private bool Pause { get; set; }

        #endregion
        #region public methods

        /// <summary>
        /// Powraca użytkownika do menu głównego przerywając jego grę
        /// </summary>
        public void BackToMenu()
        { }
        /// <summary>
        /// Otwiera okno z ustawieniami
        /// </summary>
        public void OpenSettings()
        { }
        /// <summary>
        /// Startuje lub zatrzymuje grę
        /// </summary>
        /// <param name="pause"></param>
        public void StartPause(bool pause)
        { }
        /// <summary>
        /// Funkcja obsługuje podniesienie Power Upu
        /// </summary>
        /// <param name="pu"></param>
        public void TakePowerUp(PowerUp pu)
        { }
        /// <summary>
        /// Porusza wszystkim co ma się poruszyć. Wywołuje się z pewnym sleepem co chwila
        /// </summary>
        public void MoveEverything()
        { }

        public PowerUp TakePowerUp()
        {
            return null;
        }
        #endregion
    }
}
