using Hertzeliya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTelAviv
{
    public class AvrahamSon : Avraham
    {
        public void Access_y()
        {
            Console.WriteLine($"I know Y ! it is {protected_y}");
        }

        public void Access_z()
        {
            // cannot
            // Console.WriteLine($"I know Y ! it is {internal_z}");

            Console.WriteLine(protected_internal); // ok!
        }
            
        public void Access_private_protected()
        {
            // private protected - only derived class in the same project
            //Console.WriteLine(private_protected); // i CANNOT  access!!!
        }
    }
}
