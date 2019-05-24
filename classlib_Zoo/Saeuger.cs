using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlib_Zoo
{
   public abstract class Saeuger : Haustier, IStreichelbar
    {
     public Saeuger(string name, string besitzer) : base (name, besitzer)
        {
        
        }
        public virtual void fortbewegen()
        {
            Console.WriteLine("{0} Bewegt sich", base.Name);
        }

        public virtual void streicheln()
        {
            Console.WriteLine("{0} wurde gestreichelt", Name);
        }
       
    }
    
}
