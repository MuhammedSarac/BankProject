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
    /// Interaction logic for Udbetalpenge.xaml
    /// </summary>
    public partial class Udbetalpenge : Window
    {
        public Udbetalpenge()
        {
            InitializeComponent();
        }

        private void btnudbetal_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void header_udbetal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void udbetal_opret_Click(object sender, RoutedEventArgs e)
        {
            if (txt_konto.Text != "" && txt_belob.Text != "" )
            {

            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }
        }
    }
}
