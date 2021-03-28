﻿using Edige.Dao;
using Edige.Model;
using System;

namespace Edige
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaCategoriaDao();
            //TestaAutorDao();

            Console.ReadLine();
        }

        public static void TestaAutorDao()
        {
            //Teste padrão
            //Autor autor3 = new Autor("Ana", "ana@alura.com", "Dev");
            //Autor autor4 = new Autor("Ana", "Luiza@alura.com", "Dev");

            AutorDao autorDao = new AutorDao();
            //autorDao.CadastraAutor(autor3);
            //autorDao.CadastraAutor(autor4);

            //Teste de email já cadastrado
            Autor autor1 = new Autor("Luiza", "ana@alura.com", "Adm");
            Autor autor2 = new Autor("Ana", "ana@alura.com", "Dev");

            //Exceção acontece!
            autorDao.CadastraAutor(autor1);
            autorDao.CadastraAutor(autor2);

        }

        public static void TestaCategoriaDao()
        {
            //Teste padrão
            //Categoria categoria1 = new Categoria("Tecnologia");
            Categoria categoria2 = new Categoria("Romance");

            CategoriaDao categoriaDao = new CategoriaDao();
            //categoriaDao.CadastraCategoria(categoria1);

            Categoria categoria3 = new Categoria("Romance");
            categoriaDao.CadastraCategoria(categoria2);
            categoriaDao.CadastraCategoria(categoria3);




        }
    }
}
