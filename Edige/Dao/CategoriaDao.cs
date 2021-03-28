using Edige.Model;
using System;
using System.Collections.Generic;

namespace Edige.Dao
{
    public class CategoriaDao
    {
        private IList<Categoria> Categorias { get; set; }
        public CategoriaDao()
        {
            Categorias = new List<Categoria>();
        }

        public void CadastraAutor(Categoria categoria)
        {
            if (Categorias.Contains(categoria))
            {
                throw new Exception("Categoria já possui cadastro! Favor verificar!");
            }

            Categorias.Add(categoria);

            Console.WriteLine("Autor cadastrado com sucesso!");
        }
    }
}
