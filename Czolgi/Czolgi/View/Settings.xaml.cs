using System;
using System.Collections;
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
using IndividualProjectClasses.Helpers;
using WpfControls;

namespace Czolgi.View
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            InitializeProviders();
            GetSettings();
        }

        private void InitializeProviders()
        {
            var provider = new SuggestionProvider(x =>
            {
                IEnumerable suggestions;
                List<string> help = new List<string>();
                foreach (string word in Enum.GetNames(typeof(Key)))
                {
                    string word1 = word.ToLower();
                    if (word1.StartsWith(x.ToLower()))
                        help.Add(word);
                }
                suggestions = help;
                return suggestions;
            });
            autoCompleteTop.Provider = provider;
            autoCompleteBottom.Provider = provider;
            autoCompleteLeft.Provider = provider;
            autoCompleteRight.Provider = provider;
            autoCompleteShot.Provider = provider;
        }
        private void SaveSettings()
        {
            FileHelper.SetSetting(new string[6]
           {
                autoCompleteTop.Text,
                autoCompleteBottom.Text,
                autoCompleteLeft.Text,
                autoCompleteRight.Text,
                autoCompleteShot.Text,
                CheckHelp()
           });
            GetSettings();
        }
        private void GetSettings()
        {
          string[][] settings = FileHelper.GetSettings();
            autoCompleteTop.Text = settings[1][0];
            autoCompleteBottom.Text = settings[1][1];
            autoCompleteLeft.Text = settings[1][2];
            autoCompleteRight.Text = settings[1][3];
            autoCompleteShot.Text = settings[1][4];
            if (settings[1][5] == "tak")
                soundCheckBox.IsChecked = true;
            else
                soundCheckBox.IsChecked = false;
        }

        #region events
        private void ImageArrow_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
           SaveSettings();
        }
        #endregion
        private string CheckHelp()
        {
            if (soundCheckBox.IsChecked.Value) return "tak";
            return "nie";
        }
    }
}
