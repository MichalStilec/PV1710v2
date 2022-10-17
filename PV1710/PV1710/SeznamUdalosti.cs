using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1710
{
    internal class SeznamUdalosti
    {
        private List<Udalost> udalosti = new List<Udalost>();

        public void Add(Udalost u)
        {
            udalosti.Add(u);
        }

        public SeznamUdalosti Filtr(Udalost.Typ typ, Udalost.Uroven uroven)
        {
            SeznamUdalosti seznamUdalosti = new SeznamUdalosti();
            foreach (Udalost u in udalosti)
            {
                if (u.Type == typ && u.Level == uroven)
                {
                    seznamUdalosti.Add(u);
                }
            }
            return seznamUdalosti;
        }

        //Nefunguje i kdyz je to urcite spravne
        /*public override string? ToString()
        {
            return "Udalost ma:\ntyp: " + GetType + "\nuroven : " + GetLevel + "\npopis chyby je : " + GetPopis;
        }*/
    }
}
