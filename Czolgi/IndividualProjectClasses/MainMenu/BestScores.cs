using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.MainMenu
{
    public class BestScores
    {
        #region private fields

        private string[,] Scores { get; }

        #endregion

        public BestScores()
        {
            Scores = new string[3, 11];
        }
        #region public methods
        /// <summary>
        /// Próbuje dodać nowy wynik do najlepszych wyników
        /// </summary>
        /// <param name="name"></param>
        /// <param name="newScore"></param>
        /// <returns>true jeśli ktoś ma wystarczająco dobry wynik, żeby znaleźć się w tabeli</returns>
        public bool AddNewScore(string name, string newScore)
        {
            return false;
        }
        #endregion
        #region privateMethods
        /// <summary>
        /// Po dodaniu nowego wyniku sortujenajlepsze wyniki
        /// </summary>
        private void SortScores()
        {
            
        }

        #endregion
    }
}
