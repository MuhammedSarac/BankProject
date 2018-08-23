using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    class Konto
    {
        private string _KontoName;
        private int _KontoNr;
        private int _Saldo;
        private int _Rente;
        private int _CreateDato;


        public string KontoName
        {
            set { _KontoName = value; }
            get { return _KontoName; }
        }



        public int Saldo
        {
            set { _Saldo = value; }
            get { return _Saldo; }
        }

        public int Rente
        {
            set { _Rente = value; }
            get { return _Rente; }
        }

        public int CreateDato
        {
            get => _CreateDato;
            set => _CreateDato = value;
        }
        public int KontoNr

        {
            get => _KontoNr;
            set => _KontoNr = value;
        }

        public Konto(string kontoname, int kontonr, int saldo, int rente, int dato)
        {
            KontoName = kontoname;
            KontoNr = kontonr;
            Saldo = saldo;
            Rente = rente;
            CreateDato = dato;
        }
        public override string ToString()
        {
            return string.Format($"Konto Navn: {KontoName} Kontonr: {KontoNr} Saldo: {Saldo} Rente: {Rente} OprettelsesDato {CreateDato}");
        }
    }
}
