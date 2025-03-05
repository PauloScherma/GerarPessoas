using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerarpessoas
{
    class Aluno : Pessoa
    {
        private string numeroAluno;
        private string curso;
        public Aluno(string nome, DateTime dataNascimento, string morada, string numeroAluno, string curso, string tipoDePessoa) : base(nome, dataNascimento, morada, tipoDePessoa)
        {
            this.numeroAluno = numeroAluno;
            this.curso = curso;
        }
    }
}
