﻿using System;
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

namespace Czolgi.View
{
    /// <summary>
    /// Interaction logic for Instructions.xaml
    /// </summary>
    public partial class Instructions : Window
    {
        public Instructions()
        {
            InitializeComponent();
            ShowInstruciotns();
        }
        #region public methods

        /// <summary>
        /// Tu sie dzieje wszystko co potrzebne w tym xamlu
        /// </summary>
        public void ShowInstruciotns()
        {
            textBlock.Text = FileHelper.GetInstructions();
        }
        #endregion
        private void ImageArrow_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
