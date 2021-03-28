using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edige.Model
{
    public class Categoria
    {
        private string _nome;
        public Categoria(string nome)
        {
            Nome = nome;

            DateTime dataRegistro = DateTime.Now;
            Console.WriteLine($"Categoria cadastrada em: {dataRegistro}");
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (value == null || value == "".Trim())
                {
                    throw new Exception("Categoria inválida! \nInforme uma categoria!");
                }
                
                _nome = value;
            }
        }

        public override bool Equals(object obj)
        {
            Categoria outroCategoria = obj as Categoria;

            if(Nome == outroCategoria.Nome)
            {
                return true;
                throw new Exception("Categoria já existente! \nInforme uma nova categoria!");
            }
            return false;
        }

        public override string ToString()
        {
            return $"Categoria: {Nome}";
        }
    }
}