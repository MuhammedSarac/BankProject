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
    /// Interaction logic for Indsatpenge.xaml
    /// </summary>
    public partial class Indsatpenge : Window
    {
        public Indsatpenge()
        {
            InitializeComponent();
        }

        private void btnindsat_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_indsat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void indsat_opret_Click(object sender, RoutedEventArgs e)
        {
            if (txt_konto.Text != "" && txt_belob.Text != "" && txt_date.Text != "")
            {
                
                if (dbtask.Transaktion(Convert.ToInt64(txt_konto.Text), Convert.ToDouble(txt_belob.Text), txt_date.Text))
                {
                    MessageBox.Show("Transaktion gennemført");
                }
                else
                {
                    MessageBox.Show("fejll");
                }
            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }
        }
    }
}
