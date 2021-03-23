using System;
using System.Text.RegularExpressions;

namespace Edige.Model
{
    public class Livro
    {
        private string _titulo;
        private string _isbn;
        private string _resumo;
        private string _sumario;
        private int _numeroDePaginas;
        private Autor _autor;
        private Categoria _categoria;
        private double _preco;
                

        public Livro(string titulo, string isbn, string resumo, string sumario, int numeroDePaginas, Autor autor, Categoria categoria, double preco)
        {
            Titulo = titulo;
            Isbn = isbn;
            Resumo = resumo;
            Sumario = sumario;
            NumeroDePaginas = numeroDePaginas;
            Autor = autor;
            Categoria = categoria;
            Preco = preco;

            DateTime dataRegistro = DateTime.Now;
            Console.WriteLine($"Livro cadastrado em: {dataRegistro}");
        }

        public string Titulo
        {
            get => _titulo;
            set
            {
                if (value == null || value == "".Trim())
                {
                    throw new Exception(" inválido! \nInforme um!");
                }

                _titulo = value;
            }
        }
        public string Isbn
        {
            get => _isbn;
            set
            {
                Regex regex = new Regex(@"(?:(?<ISBN>\d{10,13})|(?<TrackNumber>\d{3}))[^a-zA-Z]");
                Match match = regex.Match(value);

                if (!match.Success)
                {
                    throw new Exception("ISBN inválido! \nInforme um ISBN válido.");
                }

                _isbn = value;
            }
        }
        public string Resumo
        {
            get => _resumo;
            set
            {
                if (value == null || value == "".Trim())
                {
                    throw new Exception(" inválido! \nInforme um!");
                }

                _resumo = value;
            }
        }
        public string Sumario
        {
            get => _sumario;
            set
            {
                if (value == null || value == "".Trim())
                {
                    throw new Exception(" inválido! \nInforme um!");
                }
                _sumario = value;
            }
        }
        public int NumeroDePaginas
        {
            get => _numeroDePaginas;
            set
            {
                if (value == null)
                {
                    throw new Exception(" inválido! \nInforme um!");
                }
                _numeroDePaginas = value;
            }
        }
        public Autor Autor
        {
            get => _autor;
            set
            {
                if (value == null)
                {
                    throw new Exception(" inválido! \nInforme um!");
                }
                _autor = value;
            }
        }
        public Categoria Categoria
        {
            get => _categoria;
            set
            {
                if (value == null)
                {
                    throw new Exception(" inválido! \nInforme um!");
                }
                _categoria = value;
            }
        }
        public double Preco
        {
            get => _preco;
            set
            {
                if (value == null)
                {
                    throw new Exception(" inválido! \nInforme um!");
                }
                _preco = value;
            }
        }

        public override bool Equals(object obj)
        {
            Livro outroAutor = obj as Livro;

            return Isbn == outroAutor.Isbn;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo} \nISBN: {Isbn} \nPreço: {Preco} ";
        }

    }
}
