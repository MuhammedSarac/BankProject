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
    /// Interaction logic for Searchkunde.xaml
    /// </summary>
    public partial class Searchkunde : Window
    {
        public Searchkunde()
        {
            InitializeComponent();
        }

        private void btnsearch_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_search_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            if (txt_kundecpr.Text != "" )
            {

            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }
        }
    }
}
