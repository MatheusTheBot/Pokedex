using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Enum;

namespace Pokedex.Classes
{
    public class Pokemon : PropriedadeIndex
    {
        private string Nome { get; set; }
        private EnumTipos Tipo { get; set; }
        private EnumTipos Tipo2 { get; set; }
        private string Ataque1 { get; set; }
        private string Ataque2 { get; set; }
        private string Defesa1 { get; set; }
        public bool Excluido { get; set; }
        //Fazer: talvez alguma forma de contabilizar as evoluções do bixo;

        //método construtor
        public Pokemon(string nome, EnumTipos tipo1, EnumTipos tipo2, string ataque, string ataque2, string defesa, int index)
        {
            this.Nome = nome;
            this.Tipo = tipo1;
            this.Tipo2 = tipo2;
            this.Ataque1 = ataque;
            this.Ataque2 = ataque2;
            this.Defesa1 = defesa;
            this.Index = index;
            Excluido = false;
        }

        //refiz o ToString() pra mostrar os dado melhor
        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;

            if (Tipo == Tipo2)
            {
                retorno += "Tipo: " + this.Tipo + Environment.NewLine;
            }
            else
            {
                retorno += "Tipo: " + this.Tipo + Environment.NewLine;
                retorno += "Segundo tipo: " + this.Tipo2 + Environment.NewLine;
            }

            retorno += "Primeiro ataque: " + this.Ataque1 + Environment.NewLine;
            retorno += "Segundo ataque: " + this.Ataque2 + Environment.NewLine;
            retorno += "Defesa: " + this.Defesa1 + Environment.NewLine;
            retorno += "Index: " + this.Index + Environment.NewLine;
            return retorno;
        }
    }
}
