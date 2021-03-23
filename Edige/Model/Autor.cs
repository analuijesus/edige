using System;
using System.Text.RegularExpressions;

namespace Edige
{
    public class Autor
    {
        private string _nome;
        private string _email;
        private string _biografia;

        public Autor(string nome, string email, string biografia)
        {
            Nome = nome;
            Email = email;
            Biografia = biografia;

            DateTime dataRegistro = DateTime.Now;
            Console.WriteLine($"Autor cadastrado em: {dataRegistro}");
        }
        
        public string Nome
        {
            get => _nome;            
            set
            {
                if(value == null || value == "".Trim())
                {
                    throw new Exception("Nome inválido! \nInforme um nome!");
                }

                _nome = value;
            }
        }
        public string Email
        {
            get => _email;            
            set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(value);

                if (!match.Success)
                {
                    throw new Exception("Email inválido! \nInforme um email válido.");
                }
                _email = value;
            }
        }
        public string Biografia
        {
            get => _biografia;            
            set
            {
                if (value == null || value == "".Trim())
                {
                    throw new Exception("Nome inválido! \nInforme uma biografia.");
                }

                _biografia = value;
            }
        }

        public override bool Equals(object obj)
        {
            Autor outroAutor = obj as Autor;

            return Email == outroAutor.Email;
        }


        public override string ToString()
        {
            return $"Nome Autor: {Nome} \nEmail: {Email} \nBiografia: {Biografia}";
        }
    }
}
