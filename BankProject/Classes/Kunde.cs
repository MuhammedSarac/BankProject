using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Classes
{
    class Kunde
    {
        private int _CprNr;
        private string _Name;
        private string _LastName;
        private string _Adresse;
        private int _Telephone;
        private int _CreateDato;
        public List<Konto> Konto = new List<Konto>();


        public string Name { get => _Name; set => _Name = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public int CprNr { get => _CprNr; set => _CprNr = value; }
        public int Telephone { get => _Telephone; set => _Telephone = value; }
        public int CreateDato { get => _CreateDato; set => _CreateDato = value; }


        public Kunde(int cprnr, string name, string lastName, string adresse, int telephone, int createDato)
        {
            CprNr = cprnr;
            Name = name;
            LastName = lastName;
            Adresse = adresse;
            Telephone = telephone;
            CreateDato = createDato;
        }

        public void AddKonto(Konto a)
        {
            Konto.Add(a);
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in Konto)
            {
                s = s + " " + item + Environment.NewLine;
            }
            return string.Format($"Kundenr: {CprNr} Name: {Name} LastName: {LastName} Adresse: {Adresse} Telephone: {Telephone} CreateDato: {CreateDato}\r\nAdresser:\r\n{s}");
        }

    }
}