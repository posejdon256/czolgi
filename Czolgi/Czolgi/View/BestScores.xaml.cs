using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Czolgi.View
{
    /// <summary>
    /// Interaction logic for BestScores.xaml
    /// </summary>
    public partial class BestScores : Window
    {
        public class DataObject
        {
            public string points { get; set; }
            public string user { get; set; }
        }
        public BestScores()
        {
            InitializeComponent();
            ShowBestScores();
        }
        #region public methods

        /// <summary>
        /// Tu sie dzieje wszystko co potrzebne w tym xamlu
        /// </summary>
        public void ShowBestScores()
        {
            var list = new ObservableCollection<DataObject>();
            string[][] scores = IndividualProjectClasses.Helpers.FileHelper.GetBestScore();
            for (int i = 0; i < scores.GetLength(0); i++)
                list.Add(new DataObject() { user=scores[i][0],points=scores[i][1] });
            this.dataGrid1.ItemsSource = list;
            dataGrid1.Items.Refresh();
        }
        #endregion
        private void ImageArrow_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
