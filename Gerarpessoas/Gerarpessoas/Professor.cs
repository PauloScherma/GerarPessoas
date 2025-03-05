using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerarpessoas
{
    class Professor : Pessoa
    {
        private string disciplina;
        public Professor(string disciplina, string nome, DateTime dataNascimento, string morada, string tipoDePessoa) : base(nome, dataNascimento, morada, tipoDePessoa)
        {
            this.disciplina = disciplina;
        }
    }
}
