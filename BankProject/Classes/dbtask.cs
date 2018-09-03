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

        // list in grid all from db
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
            SQLiteCommand com = new SQLiteCommand("Insert into Konto (KundeCprNr,KontoName,KontoNr,Saldo,Rente,CreateDato) values (@KundeCprNr,@KontoName,@KontoNr,@Saldo,@Rente,@CreateDato)", conn);

            com.Parameters.AddWithValue("@KundeCprNr", konto.KundeCprNr);
            com.Parameters.AddWithValue("@KontoName", konto.KontoName);
            com.Parameters.AddWithValue("@KontoNr", konto.KontoNr);
            com.Parameters.AddWithValue("@Saldo", konto.Saldo);
            com.Parameters.AddWithValue("@Rente", konto.Rente);
            com.Parameters.AddWithValue("@CreateDato", konto.CreateDato);

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

        public static bool Gridlistkunde(DataGrid grd, long input)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM Kunde INNER JOIN Konto ON Kunde.CprNr = Konto.KundeCprNr WHERE Kunde.CprNr = '" + input + "'", conn);

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


        public static bool DeleteKunde(long cpr)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);

            try
            {
                conn.Open();
                SQLiteCommand com = new SQLiteCommand("DELETE FROM Kunde WHERE CprNr = '" + cpr + "' ", conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"Kunde med cpr: {cpr} deletted");
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

        public static bool DeleteKonto(long kontonr)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);

            try
            {
                conn.Open();
                SQLiteCommand com = new SQLiteCommand("DELETE FROM Konto WHERE KontoNr = '" + kontonr + "' ", conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"Konto med kontonr: {kontonr} deletted");
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

        public static bool Transaktion(long konto, double amount, string date)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);
            SQLiteCommand com = new SQLiteCommand("Insert into Saldo (KontoNr,Amount,Date) values (@KontoNr,@Amount,@Date)", conn);

            com.Parameters.AddWithValue("@KontoNr", konto);
            com.Parameters.AddWithValue("@Amount", amount);
            com.Parameters.AddWithValue("@Date", date);
           

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

        public static bool Saldolook(DataGrid grd, long konto)
        {
            sbyte i = 0;
            SQLiteConnection conn = new SQLiteConnection(DbConnection.DbAdress);
            SQLiteCommand com = new SQLiteCommand("SELECT Saldo.rowid,Saldo.amount,Saldo.date,(Konto.Saldo +(Saldo.amount)) AS Saldo FROM Saldo INNER JOIN Konto ON Saldo.KontoNr = Konto.KontoNr WHERE Saldo.KontoNr ='" + konto + "'", conn);

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
    }
}
