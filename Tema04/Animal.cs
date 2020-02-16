using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema04
{
    public class Animal
    {

       public string tipAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }

        public Animal()
        {
            tipAnimal = "";
            culoare = "";
            varsta = 0;
        }

        public Animal(string tipAnimal)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = "";
            this.varsta = 0;
        }

        public Animal(string tipAnimal, string culoare, int varsta)
        {
            this.tipAnimal = tipAnimal;
            this.culoare = culoare;
            this.varsta = varsta;
        }
    }
}
