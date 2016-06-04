using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using IndividualProjectClasses.Helpers;
using IndividualProjectClasses.Objects;
using MahApps.Metro.Controls;

namespace Czolgi.Controllers
{
    internal static class HUDController
    {
        internal static void GenerateHUD(ref Grid game, ref Dictionary<string, UIElement> hudElements)
        {
            Canvas cs = new Canvas();
            cs.Width = Double.NaN;
            cs.Height = Double.NaN;
            Grid.SetColumn(cs,1);
            Grid.SetRow(cs,0);
            Grid.SetColumnSpan(cs,39);
            

            Label l = new Label();
            l.Content = "Wynik: 0";
            l.FontSize = 20;
            l.Foreground = Brushes.White;
            l.HorizontalAlignment = HorizontalAlignment.Left;
            l.Margin = new Thickness(0, 10, 0, 0);
            cs.Children.Add(l);
            hudElements.Add("wynik",l);


            l = new Label();
            l.Content = "3x";
            l.FontSize = 20;
            l.Foreground = Brushes.White;
            l.HorizontalAlignment = HorizontalAlignment.Left;
            l.Margin = new Thickness(140, 10, 0, 0);
            cs.Children.Add(l);
            hudElements.Add("lifes", l);

            BitmapImage bim = (new Czolg(0, 0, 1)).ImagePath;
            Image im = new Image();
            im.Source = bim;
            im.HorizontalAlignment = HorizontalAlignment.Left;
            im.Margin = new Thickness(170,10,0,0);
            im.Height = 40;
            cs.Children.Add(im);

            l = new Label();
            l.Content = "15x";
            l.FontSize = 20;
            l.Foreground = Brushes.White;
            l.Margin = new Thickness(240, 10, 0, 0);
            cs.Children.Add(l);
            hudElements.Add("enemies", l);

            bim = (Factory.Get("cNt",0,0)).ImagePath;
            im = new Image();
            im.Source = bim;
            im.Margin = new Thickness(300, 10, 0, 0);
            im.Height = 40;
            cs.Children.Add(im);

            Button btn = new Button();
            btn.Content = "Wyjdź z gry";
            btn.Margin = new Thickness(680, 10, 0, 0);
            btn.Height = 40;
            btn.Click += Btn_Click;
            cs.Children.Add(btn);
            hudElements.Add("goOut", btn);

            CheckBox cb = new CheckBox();
            cb.IsChecked = true;
            cb.Content = "Włącz/wyłącz dźwięk";
            cb.Margin = new Thickness(530, 10, 0, 0);
            cb.Height = 40;
            cb.Foreground = Brushes.White;
            cs.Children.Add(cb);
            hudElements.Add("music", cb);

            game.Children.Add(cs);
        }

        private static void Btn_Click(object sender, RoutedEventArgs e)
        {
            ((sender as Button).Parent.GetParentObject().GetParentObject() as Window).Close();
        }
    }
}
