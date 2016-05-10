using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
        public static void SetSetting(string[] parameters)
        {
            string[][] toSave = GetSettings();
            Key ret;
            for(int i = 0; i < 5; i ++)
                if (Enum.TryParse(parameters[i], out ret))
                    toSave[1][i] = parameters[i];
            toSave[1][5] = parameters[5];
            string text = "";
            for (int i = 0; i < 6; i++)
                  text+=(toSave[0][i]+";"+toSave[1][i])+Environment.NewLine;
                File.WriteAllText(Path.Combine(System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            @"TextFiles\Settings.txt"), text);
        }
        /// <summary>
        /// Pobiera Tabele wyników z pliku
        /// </summary>
        /// <returns></returns>
        public static string[][] GetBestScore()
        {
            FileStream fs = new FileStream(Path.Combine(System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            @"TextFiles\BestScoresTxt.txt"), FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("ISO-8859-2"));
            List<string[]> ret = new List<string[]>();
            while (!sr.EndOfStream)
            {
                string[] help = sr.ReadLine().Split(';');
                ret.Add(help);
            }
            fs.Close();
            return ret.ToArray();
        }
        /// <summary>
        /// Pobiera ustawienia z pliku
        /// </summary>
        /// <returns></returns>
        public static string[][] GetSettings()
        {
            FileStream fs = new FileStream(Path.Combine(System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
           @"TextFiles\Settings.txt"), FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("ISO-8859-2"));
            string[][] ret = new string[2][];
            List<string> first = new List<string>();
            List<string> second=  new List<string>();
            while (!sr.EndOfStream)
            {
                string[] help = sr.ReadLine().Split(';');
                first.Add(help[0]);
                second.Add(help[1]);      
            }
            fs.Close();
            ret[0] = first.ToArray();
            ret[1] = second.ToArray();
            return ret;
        }
        /// <summary>
        /// Pobiera instrukcje z pliku
        /// </summary>
        /// <returns></returns>
        public static string GetInstructions()
        {
            //FileStream fs = new FileStream("BestScoresTxT.txt",FileMode.Open);
            FileStream fs = new FileStream(Path.Combine(System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                @"TextFiles\Instructions.txt"), FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("ISO-8859-2"));
            string ret = sr.ReadToEnd();
            fs.Close();
            return ret;
        }

        /// <summary>
        /// Pobiera mape czołgów
        /// </summary>
        /// <returns></returns>
        public static string[][] GetMap()
        {
            FileStream fs = new FileStream(Path.Combine(System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
          @"TextFiles\Board1.txt"), FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("ISO-8859-2"));
            List<string[]> rowsList = new List<string[]>();
            while (!sr.EndOfStream)
            {
                string[] help = sr.ReadLine().Split(';');
                rowsList.Add(help);
            }
            fs.Close();
            return rowsList.ToArray();
        }
        #endregion
    }
}
