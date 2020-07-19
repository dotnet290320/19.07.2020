using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzelia
{
    public class CohenPapa
    {
        protected int code_for_family_safe_box = 12345;

        public void OpenSafe()
        {
            Console.WriteLine($"opening safe with code {code_for_family_safe_box}");
        }

        protected void WalkInOurFamilyHouse()
        {
            Console.WriteLine("walking in our house...");
        }
    }

    internal class CohenSon : CohenPapa
    {
        public void SonOpensSafe()
        {
            Console.WriteLine($"opening safe with code {code_for_family_safe_box}");
            WalkInOurFamilyHouse();
        }
    }

    class CohenGrandSon : CohenPapa
    {
        public void GrandsonOpensSafe()
        {
            Console.WriteLine($"opening safe with code {code_for_family_safe_box}");
            WalkInOurFamilyHouse();
        }
    }
}
