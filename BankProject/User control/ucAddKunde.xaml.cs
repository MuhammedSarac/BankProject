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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankProject.User_control
{
    /// <summary>
    /// Interaction logic for ucAddKunde.xaml
    /// </summary>
    public partial class ucAddKunde : UserControl
    {
        public ucAddKunde()
        {
            InitializeComponent();
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void btn_addkunde_Click(object sender, RoutedEventArgs e)
        {
            AddKunde add = new AddKunde();
            add.Owner = gk;
            gk.Opacity = 0.3;
            add.ShowDialog();
        }
    }
}
