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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SerializerLib;

namespace Dobrojui
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            tblock.Text=Serialization.Deserialize<string>();
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SerializerLib.Serialization.Serialize<string>(tb.Text);

        }
    }
}
