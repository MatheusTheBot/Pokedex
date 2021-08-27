using System.Collections.Generic;
using Pokedex.Classes;

namespace Pokedex.Repositorio
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        void Inserir(T Pokemon);
        int ProximoID();
        Pokemon Pesquisar(int id);
    }
}
