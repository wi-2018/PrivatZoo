using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib_Zoo
{
   public class Guppy : Fisch
    {
        public Guppy(string name, string besitzer) : base(name, besitzer)
        {

        }
        public override void schwimmen()
        {
            Console.WriteLine("Guppy {0} schwimmt hin und her", Name);
        }
    }
}
