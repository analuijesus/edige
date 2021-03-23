using Edige.Dao;
using Edige.Model;
using System;

namespace Edige
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor("Ana", "ana@alura.com", "Dev");
            Categoria categoria = new Categoria("Tecnologia");
            Livro livro = new Livro("Java", "123456789", "POO", "POO", 236, autor, categoria, 59.90);

            Console.WriteLine();
            Console.WriteLine(autor);
            Console.WriteLine();
            Console.WriteLine(categoria);
            Console.WriteLine();
            Console.WriteLine(livro);

            


            Console.ReadLine();
        }
    }
}
