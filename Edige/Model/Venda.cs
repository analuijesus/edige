using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edige.Model
{
    public class Venda
    {
        private Livro livro;
        private int quantidadeVenda;

        public Venda(Livro livro, int quantidadeVenda)
        {
            Livro = livro;
            QuantidadeVenda = quantidadeVenda;

            DateTime dataRegistro = DateTime.Now;
            Console.WriteLine($"Livro vendido em: {dataRegistro}");
        }

        public Livro Livro { get => livro; set => livro = value; }
        public int QuantidadeVenda 
        { 
            get => quantidadeVenda;
            set 
            {
                if (value < 1)
                {
                    throw new Exception("A quantidade de livro(s) a ser(em) vendido(s) precisar ser acima de 1!");
                }
                quantidadeVenda = value; 
            } 
        }

        public override string ToString()
        {
            return $"Livros vendidos: {Livro} \nQuantidade de livros vendidos: {QuantidadeVenda}";
        }
    }
}
