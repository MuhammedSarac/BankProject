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

      
       
    }
}
