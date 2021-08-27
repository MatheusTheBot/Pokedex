using Pokedex.Enum;
using Pokedex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public static class ClassMenu
    {
        public static void Menu()
        {

            Console.Clear();

            Console.WriteLine("*/***************/*");
            Console.WriteLine("Pokédex ativa...");
            Task.Delay(1500).Wait();
            Console.Clear();
            Console.WriteLine("*/***************/*");
            Console.WriteLine("Bem Vindo");
            Console.WriteLine("Selecione uma das funções: ");
            Console.WriteLine("1 - Catalogar novo Pokémon");
            Console.WriteLine("2 - Visualizar um Pokémon");
            Console.WriteLine("3 - Visualizar todo o repositório");
            Console.WriteLine("4 - Atualizar dados Pokémon");
            Console.WriteLine("5 - Fechar...");

            int menuseleção = int.Parse(Console.ReadLine());

            switch (menuseleção)
            {
                case 1:
                    Catalogar();
                    break;
                case 2:
                    VisuPokemon();
                    break;
                case 3:
                    VisuTudo();
                    break;
                case 4:
                   Atualizar();
                    break;
                case 5:
                    Fechar();
                    break;
                default:
                    break;
            }
        }

        public static void ClearConsoleAtt()
        {
            Console.Clear();
            Console.WriteLine("*/***************/*");
            Console.WriteLine(".../Atualizar Pokémon...");
            Console.WriteLine();
        }

        public static void Atualizar()
        {
            ClearConsoleAtt();

            int novoIndex = 0;
            int trava = 0;
            while (trava == 0)
            {
                Console.WriteLine("Digite o Index que quer atualizar: ");
                    novoIndex = int.Parse(Console.ReadLine());
                if (novoIndex == Program.repositorio.listapokemon.Count() ||
                    novoIndex >= Program.repositorio.listapokemon.Count() ||
                    novoIndex < (Program.repositorio.listapokemon.Count() - Program.repositorio.listapokemon.Count()))
                {
                    ClearConsoleAtt();
                    Console.WriteLine("Provávelmente tu botou algo errado, vamos denovo...");
                    continue;
                }
                else
                    trava = 1;
            }
            ClearConsoleAtt();

            Console.WriteLine("Selecione os tipos correspondentes do espécime: ");
            foreach (int i in System.Enum.GetValues(typeof(EnumTipos)))
            {
                Console.WriteLine("{1} - {0}", i, System.Enum.GetName(typeof(EnumTipos), i));
            }
            int tipo = int.Parse(Console.ReadLine());
            ClearConsoleAtt();

            Console.WriteLine("O segundo tipo, ou se for de unico tipo, é só repetir: ");
            foreach (int i in System.Enum.GetValues(typeof(EnumTipos)))
            {
                Console.WriteLine("{1} - {0}", i, System.Enum.GetName(typeof(EnumTipos), i));
            }
            int tipo2 = int.Parse(Console.ReadLine());
            ClearConsoleAtt();

            Console.WriteLine("O re-nomeie: ");
            string nome = Console.ReadLine();
            ClearConsoleAtt();

            Console.WriteLine("Re-nomeie as 2 habilidades do seu espécime...");
            Console.WriteLine();
            Task.Delay(1000).Wait();
            Console.WriteLine("Primeira habilidade:");
            string hab1 = Console.ReadLine();
            ClearConsoleAtt();

            Console.WriteLine("A segunda habilidade: ");
            string hab2 = Console.ReadLine();
            ClearConsoleAtt();

            Console.WriteLine("Re-nomeie a habilidade de defesa do seu espécime: ");
            string hab3 = Console.ReadLine();
            ClearConsoleAtt();

            Program.repositorio.listapokemon[novoIndex].Excluido = true;

            Pokemon AtualizadoPokemon = new Pokemon(nome: nome,
                                              tipo1: (EnumTipos)tipo,
                                              tipo2: (EnumTipos)tipo2,
                                              ataque: hab1,
                                              ataque2: hab2,
                                              defesa: hab3,
                                              index: novoIndex);

            Program.repositorio.Inserir(AtualizadoPokemon);

            Console.WriteLine("Refazendo o catálogo...");
            Task.Delay(3000).Wait();

            Console.WriteLine();
            Console.WriteLine("Pronto, sua descoberta foi re-catalogada com sucesso!!");

            Task.Delay(3000).Wait();

            Menu();
        }

        public static void ClearConsoleCatalogar()
        {
            Console.Clear();
            Console.WriteLine("*/***************/*");
            Console.WriteLine(".../Catalogar novo Pokémon...");
            Console.WriteLine();
        }

        public static void Catalogar()
        {
            ClearConsoleCatalogar();

            Console.WriteLine("Selecione os tipos correspondentes ao seu espécime: ");
            foreach (int i in System.Enum.GetValues(typeof(EnumTipos)))
            {
                Console.WriteLine("{1} - {0}", i, System.Enum.GetName(typeof(EnumTipos), i));
            }
            int tipo = int.Parse(Console.ReadLine());
            ClearConsoleCatalogar();

            Console.WriteLine("O segundo tipo, ou se for de unico tipo, é só repetir: ");
            foreach (int i in System.Enum.GetValues(typeof(EnumTipos)))
            {
                Console.WriteLine("{1} - {0}", i, System.Enum.GetName(typeof(EnumTipos), i));
            }
            int tipo2 = int.Parse(Console.ReadLine());
            ClearConsoleCatalogar();

            Console.WriteLine("O nomeie: ");
            string nome = Console.ReadLine();
            ClearConsoleCatalogar();

            Console.WriteLine("Nomeie as 2 habilidades de do seu espécime...");
            Console.WriteLine();
            Task.Delay(1000).Wait();
            Console.WriteLine("Primeira habilidade:");
            string hab1 = Console.ReadLine();
            ClearConsoleCatalogar();

            Console.WriteLine("A segunda habilidade: ");
            string hab2 = Console.ReadLine();
            ClearConsoleCatalogar();

            Console.WriteLine("Nomeie a habilidade de defesa do seu espécime: ");
            string hab3 = Console.ReadLine();
            ClearConsoleCatalogar();

            Pokemon NovoPokemon = new Pokemon(nome: nome,
                                              tipo1: (EnumTipos)tipo,
                                              tipo2: (EnumTipos)tipo2,
                                              ataque: hab1,
                                              ataque2: hab2,
                                              defesa: hab3,
                                              index: Program.repositorio.ProximoID());

            Program.repositorio.Inserir(Pokemon: NovoPokemon);

            Console.WriteLine("Catalogando...");
            Task.Delay(3000).Wait();

            Console.WriteLine();
            Console.WriteLine("Pronto, sua descoberta foi catalogada com sucesso!!");

            Console.WriteLine();
            Console.WriteLine("O Index deste espécime é: {0}", (Program.repositorio.ProximoID() - 1));

            Task.Delay(4000).Wait();

            Menu();
        }

        public static void ClearConsoleVisuPokemon()
        {
            Console.Clear();
            Console.WriteLine("*/***************/*");
            Console.WriteLine(".../Visualizar um Pokémon...");
            Console.WriteLine();
        }

        public static void VisuPokemon()
        {
            ClearConsoleVisuPokemon();

            Console.WriteLine("Digite o Identificador do Pokémon: ");
            int consulta = int.Parse(Console.ReadLine());

            if (Program.repositorio.listapokemon[consulta].Excluido == true)
            {
                Console.WriteLine("Não existe nada aqui...");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer botão para ir ao menu: ");
                Console.ReadKey();

                Menu();

            }
            else
            {
                Console.WriteLine(Program.repositorio.Pesquisar(consulta).ToString()); 
            }            

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer botão para ir ao menu: ");
            Console.ReadKey();

            Menu();
        }

        public static void VisuTudo()
        {
            Console.Clear();
            Console.WriteLine("*/***************/*");
            Console.WriteLine(".../Visualizar todo o repositório... ");
            Console.WriteLine();

            int tamanho = Program.repositorio.listapokemon.Count();
            if (tamanho == 0)
            {                
                Console.WriteLine("Repositório vazio... Pressione qualquer botão para continuar");
                Console.ReadKey();
                Menu();
            }
            tamanho--;

            foreach (var pokemon in Program.repositorio.Lista())
            {
                if (Program.repositorio.listapokemon[tamanho].Excluido == false)
                {
                    Console.WriteLine(Program.repositorio.listapokemon[tamanho]);
                    tamanho--;
                }
                else
                    tamanho--;
            }

            Console.WriteLine();
            Console.WriteLine("Foi tudo, pressione qualquer botão para volta ao menu");
            Console.ReadKey();
            Menu();
        }

        public static void Fechar()
        {
            Console.WriteLine("Fechando...");
            Task.Delay(2000).Wait();
            Environment.Exit(0);
        }
    }
}
