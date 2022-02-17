using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOO1
{
    class Turma
    {
        string nome;
        List<Pessoa> listaPessoas;

        public string Nome { get ; set; }
        internal List<Pessoa> ListaPessoas { get; set ; }

        public Turma(String nome, List<Pessoa> listaPessoas)
        {
            ListaPessoas = listaPessoas;
        }
    }
}
