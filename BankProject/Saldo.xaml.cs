using BankProject.Classes;
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
using System.Windows.Shapes;

namespace BankProject
{
    /// <summary>
    /// Interaction logic for Saldo.xaml
    /// </summary>
    public partial class Saldo : Window
    {
        public Saldo()
        {
            InitializeComponent();
        }

        private void sog_Click(object sender, RoutedEventArgs e)
        {
            if (txt_konto.Text != "")
            {
                
                if (dbtask.Saldolook(dtg_searchedsaldo,Convert.ToInt64(txt_konto.Text)))  
                {
                    
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }

        }

        private void btnsaldo_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_saldokonto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
