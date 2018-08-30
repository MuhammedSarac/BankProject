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
    }
}
