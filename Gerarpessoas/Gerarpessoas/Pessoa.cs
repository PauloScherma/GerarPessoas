using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerarpessoas
{
    class Pessoa
    {
        public string nome;
        public DateTime dataNascimento;
        public string morada;
        public int pontuacao;
        public string tipoDePessoa;

        public Pessoa(string nome, DateTime dataNascimento, string morada, string tipoDePessoa)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.morada = morada;
            this.pontuacao = 0;
            this.tipoDePessoa = tipoDePessoa;
        }

        public int Idade()
        {
            DateTime dataAtual = DateTime.Today;
            TimeSpan idadeTimeSpan = dataAtual - this.dataNascimento;
            int idadeDias = idadeTimeSpan.Days;
            int idade = idadeDias / 365;
            return idade;
        }

        public void Pontuar()
        {
            this.pontuacao++;
        }

        override
        public string ToString()
        {
            string texto = this.nome + " (" + this.dataNascimento + "): " + this.pontuacao + " pontos";
            return texto;
        }

        public string queTipoDePessoaSou()
        {
            return this.tipoDePessoa;
        }
    }
}
