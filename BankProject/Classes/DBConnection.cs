using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    public class DbConnection
    {
        //DB Connection
        public static string DbAdress = @"Data Source=" + Environment.CurrentDirectory + "\\DB\\Bank.db;Version=3;New=False;Compress=True,Read Only= False;";
        public static string ConStatus;

        public static void ConTest()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DbAdress))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        ConStatus = "Connected to DataBase..";
                    }
                    catch (Exception)
                    {

                        ConStatus = "Connection Faild..";
                    }
                }
                else
                {
                    ConStatus = "Connected to DataBase..";
                }
            }
        }

    }
}
