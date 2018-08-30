using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BankProject.Classes
{
    class dbtask
    {

        // list in grid
        public static bool Gridlist(DataGrid grd)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);
            SQLiteCommand com = new SQLiteCommand("select * from kunde", conn);

            try
            {
                SQLiteDataAdapter adp = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Dispose();
            }
            if (i > 0) return true; else return false;
           
        }

        //add to db
        public static bool Addkunde(Kunde kunde)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);
            SQLiteCommand com = new SQLiteCommand("Insert into Kunde (CprNr,Navn,Efternavn,Adresse,CreateDate) values (@CprNr,@Navn,@Efternavn,@Adresse,@CreateDate)", conn);

            com.Parameters.AddWithValue("@CprNr", kunde.CprNr);
            com.Parameters.AddWithValue("@Navn", kunde.Name);
            com.Parameters.AddWithValue("@Efternavn", kunde.LastName);
            com.Parameters.AddWithValue("@Adresse", kunde.Adresse);
            //com.Parameters.AddWithValue("@Telephone", kunde.Telephone);
            com.Parameters.AddWithValue("@CreateDate", kunde.CreateDato);

            try
            {
                conn.Open();
                i = (sbyte)com.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Dispose();
            }
            if (i > 0) return true; else return false;
        }

        public static bool Addkonto(Konto konto)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);
            SQLiteCommand com = new SQLiteCommand("Insert into Kunde (KundeCprNr,KontoName,KontoNr,Saldo,Rente,CreateDate) values (@KundeCprNr,@KontoName,@KontoNr,@Saldo,@Rente,@CreateDate)", conn);

            com.Parameters.AddWithValue("@KundeCprNr", konto.KundeCprNr);
            com.Parameters.AddWithValue("@KontoName", konto.KontoName);
            com.Parameters.AddWithValue("@KontoNr", konto.KontoNr);
            com.Parameters.AddWithValue("@Saldo", konto.Saldo);
            com.Parameters.AddWithValue("@Rente", konto.Rente);
            com.Parameters.AddWithValue("@CreateDate", konto.CreateDato);

            try
            {
                conn.Open();
                i = (sbyte)com.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Dispose();
            }
            if (i > 0) return true; else return false;

        }


    }
}
