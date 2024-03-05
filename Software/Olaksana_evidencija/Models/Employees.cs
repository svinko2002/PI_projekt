using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olaksana_evidencija.Models
{
    /// <summary>
    /// Klasa za zaposlenike
    /// </summary>
    public class Employees
    {
        public string OIB { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string mjestoStanovanja { get; set; }
        public string brojTelefona { get; set; }
        public string email { get; set; }
    }
}
