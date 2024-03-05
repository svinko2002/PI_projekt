using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olaksana_evidencija.Models
{
    /// <summary>
    /// Klasa za uslugu
    /// </summary>
    public class Services
    {
        public int id { get; set; }
        public string vrstaUsluge { get; set; }
        public string lokacijaObavljanja { get; set; }
        public string procijenjenoVrijemeObavljanja {get; set; }
        public DateTime vrijemeObavljanja { get; set; }
        public string ponavljajucaUsluga { get; set; }
        public string ponavljajuciPodsjetnik { get; set; }
        public int vremenskiInterval { get; set; }
        public Clients client { get; set; }
        /// <summary>
        /// Vraća sve podatke usluge spojene u jedan string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return id.ToString() + vrstaUsluge + lokacijaObavljanja + procijenjenoVrijemeObavljanja + ponavljajucaUsluga + ponavljajuciPodsjetnik + vremenskiInterval + client.ime + client.prezime;
        }
    }
}
