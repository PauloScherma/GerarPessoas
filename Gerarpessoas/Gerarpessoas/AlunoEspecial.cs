using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerarpessoas
{
    class AlunoEspecial : Aluno
    {
        private string dificulade;
        public AlunoEspecial(string dificulade, string nome, DateTime dataNascimento, string morada, string numeroAluno, string curso, string tipoDePessoa) : base(nome, dataNascimento, morada, numeroAluno, curso, tipoDePessoa)
        {
            this.dificulade = dificulade;
        }
    }
}
