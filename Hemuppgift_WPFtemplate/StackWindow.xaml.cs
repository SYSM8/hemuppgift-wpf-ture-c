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
    /// Interaction logic for StackWindow.xaml
    /// </summary>
    public partial class StackWindow : Window
    {
        public StackWindow()
        {
            InitializeComponent();
     
        
        }

        //private void stackonstack();

        private void VertBtn_Checked(object sender, RoutedEventArgs e)
        {
            stackonstack.Orientation = Orientation.Vertical;

        }

        private void HoreBtn_Checked(object sender, RoutedEventArgs e)
        {
            stackonstack.Orientation = Orientation.Horizontal;

        }
    }

}
