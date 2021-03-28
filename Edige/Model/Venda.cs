using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edige.Model
{
    public class Venda
    {
        private Livro _livro;        
        private int _quantidadeVenda;
        private double _precoVenda;
        private string _padronizacaoNomeLivro;

        public Venda(Livro livro, int quantidadeVenda)
        {
            if (quantidadeVenda >= 2)
            {
                PrecoVenda = livro.Preco * quantidadeVenda;
            }
            
            Livro = livro;
            QuantidadeVenda = quantidadeVenda;

            DateTime dataRegistro = DateTime.Now;
            Console.WriteLine($"Livro vendido em: {dataRegistro}");
        }

        public Livro Livro { get => _livro; set => _livro = value; }
        public int QuantidadeVenda 
        { 
            get => _quantidadeVenda;
            set 
            {
                if (value < 1)
                {
                    throw new Exception("A quantidade de livro(s) a ser(em) vendido(s) precisar ser acima de 1!");
                }
                                
                _quantidadeVenda = value; 
            } 
        }

        public double PrecoVenda { get => _precoVenda; set => _precoVenda = value; }

        public override string ToString()
        {
            return $"Livros vendidos: {Livro} \nQuantidade de livros vendidos: {QuantidadeVenda} \nValor da venda: {PrecoVenda}" ;
        }
    }
}
