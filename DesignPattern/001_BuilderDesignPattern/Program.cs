using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DotNetStringBuilderExample();
            PokemonBagBuilderExample();
        }

        private static void PokemonBagBuilderExample()
        {
            var pokmonBagBuilder = new PokemonBagBuilder();
            Console.WriteLine(pokmonBagBuilder.GetPokemonBag());
            pokmonBagBuilder.AddPokeBal(3);
            pokmonBagBuilder.AddPokemon("Pikachu");
            pokmonBagBuilder.AddPokemon("Ditto");
            pokmonBagBuilder.AddPokemon("Ditto");
            pokmonBagBuilder.AddPokemon("Pikachu");
            Console.WriteLine(pokmonBagBuilder.GetPokemonBag());
            pokmonBagBuilder.AddPokeBal(5);
            pokmonBagBuilder.AddPokemon("Piplup");
            pokmonBagBuilder.RemovePokemon("Ditto");
            pokmonBagBuilder.AddPokemon("Mew");
            pokmonBagBuilder.AddPokemon("Squirtle");
            pokmonBagBuilder.AddPokemon("Bulbasaur");
            pokmonBagBuilder.AddPokemon("Bulbasaur");
            Console.WriteLine(pokmonBagBuilder.GetPokemonBag());
        }

        static void DotNetStringBuilderExample()
        {
            var sb = new StringBuilder();
            sb.Append("venkat");
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
            sb.AppendLine("fullstack software developer");
            Console.WriteLine(sb.ToString());
            sb.Append('(', 10);
            Console.WriteLine(sb.ToString());
            sb.Append('a', 5);
            Console.WriteLine(sb.ToString());
            sb.Insert(3, "  ||nandhni||  ");
            Console.WriteLine(sb.ToString());
        }
    }
}
