﻿using BankProject.Classes;
using BankProject.User_control;
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

namespace BankProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void brd_rightup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void AddKundeBtn_Click(object sender, RoutedEventArgs e)
        {
            UcCall.UcAdd(ContentSide, new ucAddKunde());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UcCall.UcAdd(ContentSide, new ucAddKunde());
        }
    }
}
