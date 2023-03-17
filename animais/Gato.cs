using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais
{
    public class Gato: Animal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Meow");
        }

        public void Move()
        {
            Console.WriteLine("Gato está se movendo");
        }
    }
}
