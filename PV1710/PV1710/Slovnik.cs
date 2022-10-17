using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1710
{
    internal class Slovnik
    {
        private string czech;
        private string english;
        Dictionary<string, string> dict;

        public Slovnik(Dictionary<string, string> dict, string czech, string english)
        {
            this.dict = dict;
            Czech = czech;
            English = english;
        }



        public string Czech { get => czech; set => czech = value; }
        public string English { get => english; set => english = value; }
    }
}
