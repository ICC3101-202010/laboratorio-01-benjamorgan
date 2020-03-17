using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1_benjamorgan
{
    class Persona
    {
        public string name;
        public string lastname;


        public Persona(string Aname ,string Lastname)
        {
            name = Aname;
            lastname = Lastname;
        }

        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }




        public int lanzar()
        {
            return    RandomNumber();   
        }
    }





    }

