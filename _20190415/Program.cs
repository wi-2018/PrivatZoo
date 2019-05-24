using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classlib_Zoo;

namespace _20190415
{

    class Program
    {
        static void Main(string[] args)
        {
            Guppy g = new Guppy("Hugo", "Sebi");
            Katze k = new Katze("Lili", "David");
            Goldfisch go = new Goldfisch("Goldi", "Kariko");
            Kaninchen ka = new Kaninchen("Rainer", "Chris");

            k.fortbewegen();
            ka.streicheln();
            go.schwimmen();
            g.pflegen();

            Fisch[] aquarium = new Fisch[5];

            aquarium[0] = go;
            aquarium[1] = g;
            aquarium[2] = new Goldfisch("Justus", "Simon");
            aquarium[3] = new Goldfisch("Jonas", "Anna");
            aquarium[4] = new Guppy("Hannah", "Fabsi");

            foreach (Fisch f in aquarium)
            {
                f.pflegen();
                f.schwimmen();
                if (f is Goldfisch)
                {
                    ((Goldfisch)f).streicheln();
                }
                Goldfisch g3;
                g3 = f as Goldfisch;
                if(g3 != null)
                {
                    g3.streicheln();
                }
            }

            Saeuger[] garten = new Saeuger[3];
            garten[0] = new Katze("Karl", "Alex");
            garten[1] = new Kaninchen("Nico", "Carlos");
            garten[2] = new Katze("Mize", "Sarah");
            foreach(Saeuger s in garten)
            {
                s.pflegen();
                s.streicheln();
                s.fortbewegen();
            }

            Haustier[][] zoo = new Haustier[2][];
            zoo[0] = garten;
            zoo[1] = aquarium;

            foreach(Haustier[] h in zoo)
            {
                foreach(Haustier h2 in h)
                {
                    h2.pflegen();
                }

            }
            Console.WriteLine(zoo[0][1]);

            foreach(Saeuger i in garten)
            {
                if(i is Katze)
                {
                    ((Katze)i).fressen("Hack");
                }
                else
                {
                    ((Kaninchen)i).fressen("Gras");
                }
            }

            Hausschwein manni = new Hausschwein("Manni", "Harald");

            ((IFleischfresser)manni).fressen("");   
         }
    }
}
