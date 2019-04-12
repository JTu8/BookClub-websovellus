using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppMVC.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Kirja_nimi { get; set; }
        public string Kirjailija_nimi { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Lainauspvm { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Ostospvm { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Lukemispvm { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Palautuspvm { get; set; }
    }
}
