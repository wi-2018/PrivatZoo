using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib_Zoo
{
    public class Hausschwein : Saeuger , IPflanzenfresser , IFleischfresser
    {
        public Hausschwein(string besitzer, string name) : base (name, besitzer)
        {
        }

        public override void streicheln()
        {

        }

        public override void pflegen()
        {
            
        }

        void IPflanzenfresser.fressen(string nahrung)  
        {
            Console.WriteLine("Das Hausschwein {0} von {1}, hat {2} gefressen", Name, Besitzer, nahrung);
        }

        void IFleischfresser.fressen(string nahrung)
        {
            Console.WriteLine("Das Hausschwein {0} von {1}, hat {2} gefressen", Name, Besitzer, nahrung);
        }
    }
}