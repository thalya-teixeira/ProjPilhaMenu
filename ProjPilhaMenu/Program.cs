using System;

namespace ProjPilhaMenu
{
    internal class Program
    {
        static void Menu()
        {
            PilhasLivros minhaPilha = new();
            Livro livro = new();

            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>>> MENU <<<<<");
                Console.WriteLine("1- Inserir livro na pilha");
                Console.WriteLine("2- Remover livro na pilha");
                Console.WriteLine("3- Imprimir a pilha");
                Console.WriteLine("4- Imprimir a quantidade de livros na pilha");
                Console.WriteLine("5- Localizar um livro na pilha");
                Console.WriteLine("0- Sair");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        minhaPilha.Push(LerLivro());
                        break;
                    case 2:
                        minhaPilha.Pop();

                        break;
                    case 3:
                        minhaPilha.Print();
                        break;
                    case 4:
                        Console.WriteLine("A pilha possui {0} elemento(s): ", minhaPilha.Length());
                        break;
                    case 5:
                        string titulo;
                        Console.WriteLine("Informe o título do livro que deseja localizar: ");
                        titulo = Console.ReadLine();
                        minhaPilha.AcharTitulo(titulo);
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opc != 0);
            Console.WriteLine(">>> FIM <<<");

        }

        private static Livro LerLivro()
        {
            Console.WriteLine("CADASTRO DO LIVRO:");
            Console.Write("Informe o titúlo do livro: ");
            string Titulo = Console.ReadLine();
            Console.Write("Informe o genêro do livro: ");
            string Genero = Console.ReadLine();
            Console.Write("Informe o autor do livro: ");
            string Autor = Console.ReadLine();

            return new Livro(Titulo, Genero, Autor);
        }

        static void Main(string[] args)
        {
            //LerLivro();
            Menu();

        }
    }
}
