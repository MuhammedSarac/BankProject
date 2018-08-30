using BankProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
    /// Interaction logic for AddKunde.xaml
    /// </summary>
    public partial class AddKunde : Window
    {
        public AddKunde()
        {
            InitializeComponent();
        }

        private void btn_opret_Click(object sender, RoutedEventArgs e)
        {
            DbConnection.ConTest();
        }

        private void btnkunde_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
