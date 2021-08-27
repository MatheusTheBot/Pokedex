using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Repositorio;

namespace Pokedex.Classes
{
    public class Repositorio : IRepositorio<Pokemon>
    {
        public List<Pokemon> listapokemon = new List<Pokemon>();       

        public void Inserir(Pokemon Pokemon)
        {
            listapokemon.Add(Pokemon);
        }

        public List<Pokemon> Lista()
        {
            return listapokemon;
        }

        public Pokemon Pesquisar(int i)
        {
            return listapokemon[i];
        }        

        public int ProximoID()
        {
            return listapokemon.Count();
        }
    }
}
