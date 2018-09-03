using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    class Konto
    {
        private long _KundeCprNr;
        private string _KontoName;
        private long _KontoNr;
        private double _Saldo;
        private double _Rente;
        private string _CreateDato;

        public long KundeCprNr
        {
            set { _KundeCprNr = value; }
            get { return _KundeCprNr; }
        }

        public string KontoName
        {
            set { _KontoName = value; }
            get { return _KontoName; }
        }

        public double Saldo
        {
            set { _Saldo = value; }
            get { return _Saldo; }
        }

        public double Rente
        {
            set { _Rente = value; }
            get { return _Rente; }
        }

        public string CreateDato
        {
            get => _CreateDato;
            set => _CreateDato = value;
        }
        public long KontoNr

        {
            get => _KontoNr;
            set => _KontoNr = value;
        }

        public Konto(long kundecprnr,string kontoname, long kontonr, double saldo, double rente, string dato)
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
            return string.Format($"Kunde Cpr Nr: {KundeCprNr}Konto Navn: {KontoName}Kontonr: {KontoNr} Saldo: {Saldo} Rente: {Rente} OprettelsesDato {CreateDato}");
        }
    }
}
