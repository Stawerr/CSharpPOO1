using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOO1
{
    class Pessoa
    {
       //DEFINIR OS ATRIBUTOS
       // string nome;
       // string email;
       // double altura;
       // int telefone;

        //DEFINIR OS ATRIBUTOS E ENCAPSULAMENTO
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Altura { get; set; }
        public int Telefone { get; set; }


        //CONSTRUTORES

        public Pessoa()
        {
            Nome = "";
            Email = "";
            Altura = 0;
            Telefone = 351;
        }

        public Pessoa(string nome, string email, double altura, int telefone)
        {
            Nome = nome;
            Email = email;
            Altura = altura;
            Telefone = telefone;
        }
        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
            Altura = 0;
            Telefone = 0;
        }
        public Pessoa(Pessoa p)
        {
            Nome = p.Nome;
            Email = p.Email;
            Altura = p.Altura;
            Telefone = p.Telefone;
        }



        //ENCAPSULAMENTO
        // public string Nome { get => nome; set => nome = value; }
        // public string Email { get => email; set => email = value; }
        // public double Altura { get => altura; set => altura = value; }
        // public int Telefone { get => telefone; set => telefone = value; }


        //OVERRIDE METHODS
        public override string ToString()
        {
            return "Nome: "+ Nome+" Email: "+Email+ " Altura: " + Altura + " Telefone: " + Telefone;
        }

        public override bool Equals(object obj)
        {
            Pessoa p = obj as Pessoa;

            //if (((Pessoa)obj).Nome == Nome) linha de cima dificultada
            //{

            //}

            if (p.Nome == Nome && p.Email==Email)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
