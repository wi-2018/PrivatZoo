using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classlib_Zoo
{

    public abstract class Haustier : System.Object
    {
        private string name;
        private string besitzer;
        public Haustier(string name, string besitzer)
        {
            this.name = name;
            this.besitzer = besitzer;
            
        }
        public string Besitzer {
            get
            {
                return besitzer;
            }
            set
            {
                besitzer = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public abstract void pflegen();

        public override string ToString()
        {
            return besitzer + ", " + name;
        }

    }

}
