using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppMVC.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Kirja_nimi { get; set; }
        public string Kirjailija_nimi { get; set; }
        public string Lainauspvm { get; set; }
        public string Ostospvm { get; set; }
        public string Lukemispvm { get; set; }
        public string Palautuspvm { get; set; }
    }
}
