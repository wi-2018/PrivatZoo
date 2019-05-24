using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib_Zoo
{
  public abstract class Fisch : Haustier 
    {
        public Fisch(string name, string besitzer) : base(name, besitzer)
        {

        }

        public virtual void schwimmen()
        {
            Console.WriteLine("{0} schwimmt",Name);
        }
        public override void pflegen()
        {
            wasserwechseln();
        }
        private void wasserwechseln()
        {
            Console.WriteLine("Wasser wird gewechselt");
        }
    }

}
