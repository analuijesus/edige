using System;
using System.Collections.Generic;

namespace Edige.Dao
{
    public class AutorDao
    {
        public AutorDao()
        {
            Autores = new List<Autor>();
        }
        public IList<Autor> Autores { get; set; }

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
