using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class pokemon_class
    {

        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected pokemon_type type;
        protected pokemonAbilities abilities;

        protected int HP;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;
    
        public string Name() 
        { 
            return name; 
        }
        public Image Picture()
        {
            return pic;
        }
    
    }
    public enum pokemon_type
    {
        Grass, Poisen , Electr
    }
   public enum pokemonAbilities
    {
        Overgrow , chlorophyII , Static , Lightning_Rod 
    }



}
