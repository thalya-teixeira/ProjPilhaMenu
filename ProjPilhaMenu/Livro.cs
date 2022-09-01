using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaMenu
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { get; set; } //esse atributo vai apontar para um objeto que é do mesmo tipo da classe

        public Livro(string titulo, string genero, string autor)
        {
            Titulo = titulo;
            Genero = genero;
            Autor = autor;
            Anterior = null;
        }

        public Livro()
        {
        }

        public override string ToString()
        {
            return "\nDADOS DO LIVRO:\nTitulo: " + Titulo + "\nGenêro: " + Genero + "\nAutor: " + Autor;
        }
    }
}
