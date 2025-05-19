using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Modeli
{
    public class Ucenik
    {
        #region Svojstva

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        #endregion

        #region Metode

        public Ucenik(string ime, string prezime, DateTime datumRodjenja, double prosjek)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Prosjek = prosjek;
        }
        /// <summary>
        /// Vraća zaokruženu starost učenika u godinama
        /// </summary>
        /// <returns></returns>
        public int Starost()
        {
            return DateTime.Now.Year - DatumRodjenja.Year;
        }
        /// <summary>
        /// Ispisuje prosjek u opisnom formatu
        /// </summary>
        /// <returns></returns>
        public string IspisProsjeka()
        {
            string opisnaOcjena;
            switch (Prosjek)
            {
                case double p when (p >= 1 && p <= 1.49):
                    opisnaOcjena =  "nedovoljan";
                    break;
                case double p when (p >= 1.50 && p <= 2.49):
                    opisnaOcjena =  "dovoljan";
                    break;
                case double p when (p >= 2.50 && p <= 3.49):
                    opisnaOcjena = "dobar";
                    break;
                case double p when (p >= 3.50 && p <= 4.49):
                    opisnaOcjena = "vrlo dobar";
                    break;
                case double p when (p >= 4.50 && p <= 5):
                    opisnaOcjena = "odličan";
                    break;
                default:
                    opisnaOcjena = "nije ispravna ocjena";
                    break;
            }

            return opisnaOcjena; 
        }


        #endregion
    }
}
