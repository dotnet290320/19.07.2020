using Hertzeliya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTelAviv
{
    public class LeviPapa
    {
        public void TalkToCohenPapa()
        {

            // acess modifiers prevents access for:
            // class
            // member (field)
            // functions

            // when we using Hertzeliya it makes you avoid writing the log: Hertzeliya.CohenPapa 

            CohenPapa cp = new CohenPapa();
            cp.OpenSafe(); // public
            cp.bad_to_create_public_field = -1; // public

            // cannot be accessed outside the assembly (project) -- internal
            //cp.knowledge_known_in_Hertzelia = 1; // internal

            // cannot be accessed outside the class -- private
            //cp.OnlyPapaCanAccessThis(); 

            // cannot be accessed outside the family of inheritance -- protected
            //cp.code_for_family_safe_box

            // cannot be accessed outside the assembly (project) -- internal
            // CohenSon cs = new CohenSon(); 


        }

        public void TryAccessAvrahamProtected()
        {
            AvrahamSon avrahamSon = new AvrahamSon();
            // cannot access protected field
            // since this class does not inherts from Avraham
            //avrahamSon.y -- protected

        }
    }


}
