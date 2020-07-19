using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzeliya
{

    public class CohenPapa
    {
        protected int code_for_family_safe_box = 12345;

        public int bad_to_create_public_field = -1;



        internal int knowledge_known_in_Hertzelia = 9999;

        private void OnlyPapaCanAccessThis()
        {
            Console.WriteLine("This is accessible only for papa");
        }

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

    internal class CohenGrandSon : CohenPapa
    {
        public void GrandsonOpensSafe()
        {
            Console.WriteLine($"opening safe with code {code_for_family_safe_box}");
            WalkInOurFamilyHouse();

            Avraham a = new Avraham();
            Console.WriteLine(a.protected_internal);
        }
    }

}
