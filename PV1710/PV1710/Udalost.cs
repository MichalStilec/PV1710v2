using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1710
{
    internal class Udalost
    {
        private string popis;

        public Udalost(Typ type, Uroven level, string popis)
        {
            Popis = popis;
            Type = type;
            Level = level;
        }

        public enum Typ
        {
            Systemova,
            Hardwarova,
            Aplikacni

        }

        public enum Uroven
        {
            Informace,
            Varovani,
            Chyba

        }


        public Typ Type { get; set; }
        public Uroven Level { get; set; }
        public string Popis { get => popis; set => popis = value; }
 
        public override string? ToString()
        {
            return "Udalost ma:\ntyp: " + Type + "\nuroven : " + Level + "\npopis chyby je : " + Popis;
        }
    }
}
