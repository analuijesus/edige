using System;
using System.Collections.Generic;

namespace Edige.Dao
{
    public class AutorDao
    {
        private IList<Autor> Autores { get; set; }

        public AutorDao()
        {
            Autores = new List<Autor>();
        }

        public void CadastraAutor(Autor autor)
        {
            if (Autores.Contains(autor))
            {
                throw new Exception("Autor já possui cadastro! Favor verificar!");
            }

            Autores.Add(autor);

            Console.WriteLine("Autor cadastrado com sucesso!");                      

        }    
    }
}
