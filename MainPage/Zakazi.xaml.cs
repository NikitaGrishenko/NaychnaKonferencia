﻿using NaychnaKonferencia.Aplicationdata;
using System;
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

namespace NaychnaKonferencia.MainPage
{
    /// <summary>
    /// Логика взаимодействия для Zakazi.xaml
    /// </summary>
    public partial class Zakazi : Page
    {
        public Zakazi()
        {
            InitializeComponent();
        }

        private void btnVixod_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new Texnic());
        }
    }
}
