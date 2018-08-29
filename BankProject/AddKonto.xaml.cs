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
            using (SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                    }
                    catch (Exception)
                    {

                        DbConnection.ConStatus = "Connection Faild..";
                    }
                }
                else
                {

                }
            }
        }
    }
}
