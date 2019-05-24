using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib_Zoo
{
    public class Katze : Saeuger , IFleischfresser
    {
        public Katze (string name, string besitzer) : base (name, besitzer)
        {

        }

        public override void  pflegen()
        {
            Console.WriteLine("{0} wird gebürstet.", Name);
        }

        public override void fortbewegen()
        {
            Console.WriteLine("{0} schleicht.", Name);
        }

        public void schnurren()
        {
            Console.WriteLine("{0} schnurrt.", Name);
        }

        public override void streicheln()
        {
            schnurren();
        }

        public void fressen(string nahrung)
        {
            Console.WriteLine("Die Katze {0} von {1}, hat {2} gefressen", Name, Besitzer, nahrung);
        }
    }
}