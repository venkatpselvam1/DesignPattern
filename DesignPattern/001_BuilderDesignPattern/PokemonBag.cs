using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BuilderDesignPattern
{
    internal class PokemonBag
    {
        public Dictionary<String, int> Pokemons = new Dictionary<String, int>();
        public int PokeBalls = 0;
        public override string ToString()
        {
            var str = "";
            foreach(string pokemon in Pokemons.Keys)
            {
                str +=pokemon+" - " + Pokemons[pokemon]+"\n";
            }
            return "Total Empty Balls Available: "+PokeBalls+"\n"+ str;
        }
    }
}
