using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib_Zoo
{
    public class Goldfisch : Fisch, IStreichelbar
    {
        public Goldfisch(string name, string besitzer) : base(name, besitzer)
        {

        }
        public override void schwimmen()
        {
            Console.WriteLine("Goldfisch {0} schwimmt im Kreis", Name);
        }

        public void streicheln()
        {
            Console.WriteLine("{0} wurde gestreichelt", Name);
        }
   }
}
