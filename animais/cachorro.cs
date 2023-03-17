using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais
{
    internal class cachorro: Animal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Woof");
        }

        public void Move()
        {
            Console.WriteLine("Cachorro está se movendo");
        }
    }
}
