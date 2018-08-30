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
            if (txt_name.Text != "" && txt_eftername.Text != "" && txt_date.Text != "" && txt_adresse.Text != "" && txt_cprnr.Text != "")
            {
                Kunde kunde = new Kunde(Convert.ToInt64(txt_cprnr.Text),txt_name.Text,txt_eftername.Text,txt_adresse.Text,Convert.ToInt64(txt_date.Text));

                if (dbtask.Addkunde(kunde))
                {
                    MessageBox.Show("Kunde oprettet");
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

        private void btnkunde_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_addkunde_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
