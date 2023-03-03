using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BuilderDesignPattern
{
    internal class PokemonBagBuilder
    {
        PokemonBag PokemonBag = new PokemonBag();
        public PokemonBag GetPokemonBag()
        {
            return PokemonBag;
        }
        public void AddPokeBal(int cnt = 1)
        {
            this.PokemonBag.PokeBalls += cnt;
        }
        public bool AddPokemon(string pokemon)
        {
            if (this.PokemonBag.PokeBalls == 0) return false;
            this.PokemonBag.PokeBalls--;
            if (!this.PokemonBag.Pokemons.ContainsKey(pokemon))
            {
                this.PokemonBag.Pokemons.Add(pokemon, 1);
            }
            else
            {
                this.PokemonBag.Pokemons[pokemon] += 1;
            }
            return true;
        }
        public bool RemovePokemon(string pokemon)
        {
            if (!this.PokemonBag.Pokemons.ContainsKey(pokemon)) return false;
            this.PokemonBag.PokeBalls++;
            this.PokemonBag.Pokemons[pokemon] -= 1;
            if (this.PokemonBag.Pokemons[pokemon] == 0) this.PokemonBag.Pokemons.Remove(pokemon);
            return true;
        }
    }
}
