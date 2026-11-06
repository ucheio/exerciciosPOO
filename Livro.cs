using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Livro
    {
        public string? Titulo {get; set;}
        public string? Autor {get; set;}
        public int NumeroPaginas {get; set;}

        public Livro();

        public Livro (string titulo)
        {
            Titulo = titulo;
        }
        public Livro (string titulo, string autor)
        {
            Titulo = titulo;
            Autor = Autor;
        }
        public Livro (string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }
    
    
    }
}