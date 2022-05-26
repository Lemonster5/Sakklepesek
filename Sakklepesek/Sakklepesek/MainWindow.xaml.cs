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

namespace Sakklepesek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Felulet();
        }

        private void Felulet()

        {
            ComboBox babuk = new ComboBox();
            babuk.Items.Add("Király");
            babuk.Items.Add("Királynő");
            babuk.Items.Add("Bástya");
            babuk.Items.Add("Futó");
            babuk.Items.Add("Huszár");
            babuk.Items.Add("Világos gyalog");
            babuk.Items.Add("Sötét gyalog");
            ablak.Children.Add(babuk);
            babuk.Height = 25;
        }

    }
}
