using Edige.Model;
using System;
using System.Collections.Generic;

namespace Edige.Dao
{
    public class CategoriaDao
    {
        public ISet<Categoria> Categorias { get; set; }

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
