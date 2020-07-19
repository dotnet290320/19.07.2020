using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzeliya
{
    class AvrahamGrandson : Avraham
    {
        public void Access_private_protected()
        {
            Console.WriteLine(private_protected); // i can access!!!
        }
    }
}
