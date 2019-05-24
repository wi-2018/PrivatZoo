using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib_Zoo
{
    public class Kaninchen : Saeuger , IPflanzenfresser
    {
        public Kaninchen(string name, string besitzer) : base (name, besitzer)
        {

        }

        public override void pflegen()
        {
            Console.WriteLine("Der Stall von {0} wurde ausgemistet.", Name);
        }

        public override void fortbewegen()
        {
            Console.WriteLine("{0} hoppelt.", Name);
        }

        public void fressen(string nahrung)
        {
            Console.WriteLine("Das Kaninchen {0} von {1}, hat {2} gefressen", Name, Besitzer, nahrung);
        }
    }
}