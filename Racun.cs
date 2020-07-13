using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    class Racun
    {
        private string brojRacuna;
        private string imeKorisnika;
        private double sredstvaNaRacunu;
        private double dozvoljeniMinus;

        public Racun(string brojRacuna, string imeKorisnika, double sredstvaNaRacunu, double dozvoljeniMinus)
        {
            this.brojRacuna = brojRacuna;
            this.imeKorisnika = imeKorisnika;
            this.sredstvaNaRacunu = sredstvaNaRacunu;
            this.dozvoljeniMinus = dozvoljeniMinus;
        }

        public string BrojRacuna
        {
            get
            {
                return brojRacuna;
            }
            
        }

        public string ImeKorisnika
        {
            get
            {
                return imeKorisnika;
            }
            
        }

        public double SredstvaNaRacunu
        {
            get
            {
                return sredstvaNaRacunu;
            }
        }

        public  bool SkiniPareSaRacuna(double suma)
        {
            if (SredstvaNaRacunu - suma > dozvoljeniMinus)
            {
                sredstvaNaRacunu -= suma;
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        public void DodajPareNaRacun(double suma)
        {
            sredstvaNaRacunu += suma;
        }
    }
}
