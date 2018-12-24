using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Chien:Animal
    {
        private string race;

        public Chien()
            {
            race = "setter";
            }
        public Chien(string racerecu)
        {
            race = racerecu;
        }

        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                race = value;
            }
        }
    
        public void aboyer()
        {
            Console.WriteLine("wouah");
        }
    }
}
