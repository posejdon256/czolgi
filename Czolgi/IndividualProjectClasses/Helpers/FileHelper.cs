using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectClasses.Helpers
{
    public static class FileHelper
    {
        #region public methods
        /// <summary>
        /// Zapisuje tabele wyników w pliku
        /// </summary>
        /// <param name="scoresTable"></param>
        public static void SetScores(string[,] scoresTable)
        { }
        /// <summary>
        /// Wpisuje ustawienie do pliku
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="value"></param>
        public static void SetSetting(string parameter, string value)
        { }
        /// <summary>
        /// Pobiera Tabele wyników z pliku
        /// </summary>
        /// <returns></returns>
        public static string[,] GetBestScore()
        {
            return null;
        }
        /// <summary>
        /// Pobiera ustawienia z pliku
        /// </summary>
        /// <returns></returns>
        public static string[,] GetSettings()
        {
            return null;
        }
        /// <summary>
        /// Pobiera instrukcje z pliku
        /// </summary>
        /// <returns></returns>
        public static string GetInstructions()
        {
            return null;
        }
        #endregion
    }
}
