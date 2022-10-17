namespace PV1710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Udalost u1 = new(Udalost.Typ.Hardwarova, Udalost.Uroven.Chyba, "Nemam sebemensi tuseni");
            Udalost u2 = new(Udalost.Typ.Aplikacni, Udalost.Uroven.Chyba, "Nemam sebemensi tuseni");
            Udalost u3 = new(Udalost.Typ.Systemova, Udalost.Uroven.Varovani, "Nemam sebemensi tuseni");
            Udalost u4 = new(Udalost.Typ.Aplikacni, Udalost.Uroven.Informace, "Nemam sebemensi tuseni");
            Udalost u5 = new(Udalost.Typ.Systemova, Udalost.Uroven.Varovani, "Nemam sebemensi tuseni");

            Console.WriteLine(u1);

            Console.WriteLine();

            SeznamUdalosti seznam = new SeznamUdalosti();
            //Console.WriteLine(seznam.Filtr(Udalost.Typ.Hardwarova, Udalost.Uroven.Chyba));
            
        }
    }
}