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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockWindow.xaml
    /// </summary>
    public partial class DockWindow : Window
    {
        public DockWindow()
        {
            InitializeComponent();
        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            CenterButton.Visibility = Visibility.Collapsed;
            TrophyImage.Source = new BitmapImage(new Uri("C:\\Users\\turec\\Source\\Repos\\hemuppgift-wpf-ture-c\\Hemuppgift_WPFtemplate\\TrophyImage.jpg"));
            TrophyImage.Visibility = Visibility.Visible;
        }
    }
}
