using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    class Konto
    {
        private int _KundeCprNr;
        private string _KontoName;
        private int _KontoNr;
        private decimal _Saldo;
        private int _Rente;
        private int _CreateDato;

        public int KundeCprNr
        {
            set { _KundeCprNr = value; }
            get { return _KundeCprNr; }
        }

        public string KontoName
        {
            set { _KontoName = value; }
            get { return _KontoName; }
        }

        public decimal Saldo
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

        public Konto(int kundecprnr, string kontoname, int kontonr, int saldo, int rente, int dato)
        {
            KundeCprNr = kundecprnr;
            KontoName = kontoname;
            KontoNr = kontonr;
            Saldo = saldo;
            Rente = rente;
            CreateDato = dato;
        }
        public override string ToString()
        {
            return string.Format($"Kunde Cpr Nr: {KundeCprNr}Konto Navn: {KontoName} Kontonr: {KontoNr} Saldo: {Saldo} Rente: {Rente} OprettelsesDato {CreateDato}");
        }
    }
}
