using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Animal
    {
        private int nombreDePattes;
        private bool queue;
        public Animal()
        {
          nombreDePattes = 4;
           queue = true;
        }
        public Animal(int nombredepattesrecu, bool queuerecu)
        {
            nombreDePattes = nombredepattesrecu;
           queue = queuerecu;
        }

        public int NombreDePattes
        {
            get
            {
                return nombreDePattes;
            }

            set
            {
                nombreDePattes = value;
            }
        }

        public bool Queue
        {
            get
            {
                return queue;
            }

            set
            {
                queue = value;
            }
        }
    }
    }
  
  