using System;

namespace BankProject.Classes
{
    public class DBConnection
    {


        public static string DBAdress = @"Data Source=" + Environment.CurrentDirectory +
                                        "\\DB\\Bank.db;Version=3;New=False;Compress=True;Read Only;False;";

    }
}