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

namespace BankProject
{
    /// <summary>
    /// Interaction logic for deleteKonto.xaml
    /// </summary>
    public partial class deleteKonto : Window
    {
        public deleteKonto()
        {
            InitializeComponent();
        }

        private void btndelete_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
