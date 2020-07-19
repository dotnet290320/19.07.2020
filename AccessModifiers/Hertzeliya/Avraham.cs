using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzeliya
{
    public class Avraham
    {
        public int public_x;
        protected int protected_y;
        internal bool internal_z;

        protected internal int protected_internal = 12;

        // access only for derived class + in the same project (assembly)!!
        private protected int private_protected = 12;
    }
}
