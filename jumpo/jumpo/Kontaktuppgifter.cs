using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpo
{
    class Kontaktuppgifter
    {
        //Medlemsvariabler
        private string förnamn = "";
        private string efternamn = "";
        private int telefonnummer = 0;
        private string personnummer = "";
        private string adress = "";

        //Konstruktor
        public Kontaktuppgifter ( string förnamn, string efternamn, int telefonnummer, string personnummer, string adress)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.telefonnummer = telefonnummer;
            this.personnummer = personnummer;
            this.adress = adress;
        }

        //Egenskaper
        public string Förnamn
        {
            get
            {
                return förnamn;
            }

            set
            {
                förnamn = value;
            }
        }
        public string Efternamn
        {
            get
            {
                return efternamn;
            }

            set
            {
                efternamn = value;
            }
        }
        public int Telefonnummer
        {
            get
            {
                return telefonnummer;
            }

            set
            {
                telefonnummer = value;
            }
        }
        public string Personnummer
        {
            get
            {
                return personnummer;
            }

            set
            {
                personnummer = value;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }
    }
}
