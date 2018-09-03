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
    /// Interaction logic for AddKonto.xaml
    /// </summary>
    public partial class AddKonto : Window
    {
        public AddKonto()
        {
            InitializeComponent();
        }

        private void kontobtn_opret_Click(object sender, RoutedEventArgs e)
        {
            if (txt_kundecpr.Text != "" && txt_saldo.Text != "" && txt_rente.Text != "" && txt_konto.Text != "" && txt_dato.Text != "" && txt_kontonr.Text != "")
            {
                Konto konto = new Konto(Convert.ToInt64(txt_kundecpr.Text),txt_konto.Text, Convert.ToInt64(txt_kontonr.Text), Convert.ToDouble(txt_saldo.Text), Convert.ToDouble(txt_rente.Text), txt_dato.Text);

                if (dbtask.Addkonto(konto))
                {
                    MessageBox.Show("Konto oprettet");
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

        private void btnkonto_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_addkonto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
