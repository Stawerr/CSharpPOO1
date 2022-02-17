using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOO1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Pessoa p1 = new Pessoa();
            p1.Nome = "João";
            p1.Email = "joao@atec.pt";
            p1.Telefone = 913424092;

            Pessoa p2 = new Pessoa();
            p2.Nome = "Ana";
            p2.Email = "ana@atec.pt";

            //Pessoa p3 = new Pessoa("Ana", "ana@atec.pt",1.60,913424092);
            Pessoa p4 = new Pessoa("jonh", "john@atec.pt",0,0);

            Pessoa p6 = new Pessoa(p1);
            Console.WriteLine(p1.ToString()); // Imprime o objeto
            Console.WriteLine(p1.GetHashCode()); // Mostra o ID gerado para o objeto
            Console.WriteLine(p1.Equals(p6)); // compara 2 objetos e retorna true or false
            
            //Listas em vez de arrays
            List<Pessoa> listaPessoas = new List<Pessoa>(); // Criar a lista

            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            listaPessoas.Add(new Pessoa("Ana", "ana@atec.pt", 1.60, 913424092));
            listaPessoas.Add(p4);
            listaPessoas.Add(new Pessoa("jonh", "john@atec.pt", 0, 0));


            // listaPessoas.RemoveAt(6); remove uma pessoa

            for (int i = 0; i < listaPessoas.Count; i++)
            {
               // Console.WriteLine(listaPessoas[i].ToString());
            }

            Turma tpsi = new Turma("TPSIP 10 21", listaPessoas);
            for(int i = 0; i < tpsi.ListaPessoas.Count; i++)
            {
                Console.WriteLine(tpsi.ListaPessoas[i].ToString());
            }
        }
    }
}
