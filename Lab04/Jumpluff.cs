using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04
{
    public class Jumpluff : pokemon_class
    {
        public Jumpluff()
        {
            name = "Jumpluff";
            id = 55;
            type = pokemon_type.Electr;
            pic = Properties.Resources.Jumpluff;
        }   
    }
}
