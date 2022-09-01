using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaMenu
{
    internal class PilhasLivros : Livro
    {
        public Livro TOPO { get; set; } //topo está controlando 

        public PilhasLivros()
        {
            TOPO = null;
            Console.WriteLine("Pilha criada com sucesso!");
        }

        public void Push(Livro aux) //para inserir
        {
            if(Vazia())
                TOPO = aux;
            else
            {
                aux.Anterior = TOPO;
                TOPO = aux;
            }
            
        }

        private bool Vazia() // é private porque só o metodo push ira acessar
        {
            if(TOPO == null)
                return true;
            else
                return false;
        }

        public void Print() // para imprimir
        {
            if(Vazia())
                Console.WriteLine("A pilha está vazia!");
            else
            {
                Livro aux = TOPO;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                }while(aux != null);
                Console.WriteLine("\nFIM DA IMPRESSÃO!");
            }
        }

        public void AcharTitulo(string titulo)
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                Livro aux = TOPO;
                bool achou = false;
                do
                {
                    if (aux.Titulo.Equals(titulo))
                    {
                        Console.WriteLine("Livro Localizado:");
                        Console.WriteLine(aux.ToString());
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        achou = true;
                    }
                    aux = aux.Anterior;

                } while (aux != null);
                if (!achou)
                    Console.WriteLine("Livro não localizado com esse titulo: " + titulo);
                else
                    Console.WriteLine("Fim da Busca");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public int Length()
        {
            if (Vazia())
                return 0;
            else
            {
                Livro aux = TOPO;
                int qtd = 0;
                do
                {
                    qtd++;
                    aux = aux.Anterior;

                } while (aux != null);
                return qtd;
            }
        }
        public void Pop() // para remover
        {
            if(Vazia())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                TOPO = TOPO.Anterior;
            }
        }

    }
}
