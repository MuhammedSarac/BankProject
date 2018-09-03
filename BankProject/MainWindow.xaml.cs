using BankProject.Classes;
using BankProject.User_control;
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

namespace BankProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void brd_rightup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void AddKundeBtn_Click(object sender, RoutedEventArgs e)
        {
            UcCall.UcAdd(ContentSide, new ucAddKunde());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UcCall.UcAdd(ContentSide, new ucAddKunde());
            DbConnection.ConTest();
            ConnectionStatus.Content = DbConnection.ConStatus;
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_fullscreen_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal; 
            }
        }
        MainWindow ok = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void btn_opretkonto_Click(object sender, RoutedEventArgs e)
        {
            AddKonto add = new AddKonto();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void sog_kunde_Click(object sender, RoutedEventArgs e)
        {


            Searchkunde add = new Searchkunde();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }

        private void indsat_btn_Click(object sender, RoutedEventArgs e)
        {
            Indsatpenge add = new Indsatpenge();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }

        private void udbetal_btn_Click(object sender, RoutedEventArgs e)
        {
            Udbetalpenge add = new Udbetalpenge();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }

        private void slet_kunde_Click(object sender, RoutedEventArgs e)
        {
            deletekunde add = new deletekunde();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }

        private void slet_konto_Click(object sender, RoutedEventArgs e)
        {
            deleteKonto add = new deleteKonto();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }

        private void Saldo_btn_Click(object sender, RoutedEventArgs e)
        {
            Saldo add = new Saldo();
            add.Owner = ok;
            //ok.Opacity = 0.3;
            add.ShowDialog();
        }
    }
}
