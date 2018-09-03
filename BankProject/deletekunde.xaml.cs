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
    /// Interaction logic for deletekunde.xaml
    /// </summary>
    public partial class deletekunde : Window
    {
        public deletekunde()
        {
            InitializeComponent();
        }

        private void deltekunde_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_deletekunde_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void slet_opret_Click(object sender, RoutedEventArgs e)
        {
            if (txt_kundecpr.Text != "")
            {
                dbtask.DeleteKunde(Convert.ToInt64(txt_kundecpr.Text));

            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }
        }
    }
}
