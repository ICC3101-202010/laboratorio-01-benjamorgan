using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1_benjamorgan
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("Bob", "Kunga");
            Console.WriteLine(persona1.lanzar());
            Console.ReadLine();
        }
    }
}
