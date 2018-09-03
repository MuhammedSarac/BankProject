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
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void btn_search_Click(object sender, RoutedEventArgs e)
        {


            if (txt_kundecpr.Text != "")
            {
                
                if (dbtask.Gridlistkunde(grd: dtg_searchedkunde, input: Convert.ToInt64(txt_kundecpr.Text))) 
                {
                   
                }
                else
                {
                    
                }

            }
            else
            {
                MessageBox.Show("Udfyld alle felter!!");
            }
        }

        private void showall_Click(object sender, RoutedEventArgs e)
        {
            dbtask.Gridlist(dtg_searchedkunde);


        }
    }
}
