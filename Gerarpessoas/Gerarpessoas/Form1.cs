using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerarpessoas
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pontuar_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Pessoa pessoa1 = (Pessoa)listBox1.Items[index];
            pessoa1.Pontuar();
            listBox1.Items[index] = pessoa1;
        }

        private void adicionarAluno_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            DateTime dataNascimento = monthCalendar1.SelectionRange.Start;
            string morada = textBoxMorada.Text;
            string tipoDePessoa = "Aluno";
            string numeroAluno = textBoxNAluno.Text;
            string curso = textBoxCurso.Text;
            Aluno aluno = new Aluno(nome, dataNascimento, morada, numeroAluno, curso, tipoDePessoa);
            listBox1.Items.Add(aluno);
        }
        private void adicionarAlunoEspecial_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            DateTime dataNascimento = monthCalendar1.SelectionRange.Start;
            string morada = textBoxMorada.Text;
            string tipoDePessoa = "Aluno Especial";
            string numeroAluno = textBoxNAluno.Text;
            string curso = textBoxCurso.Text;
            string dificuldade = textBoxDificuldade.Text;
            AlunoEspecial aluno = new AlunoEspecial(dificuldade, nome, dataNascimento, morada,  numeroAluno, curso, tipoDePessoa);
            listBox1.Items.Add(aluno);
        }
        private void adicionarProfessor_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            DateTime dataNascimento = monthCalendar1.SelectionRange.Start;
            string morada = textBoxMorada.Text;
            string tipoDePessoa = "Professor";
            string numeroAluno = textBoxNAluno.Text;
            string curso = textBoxCurso.Text;
            string disciplina = textBoxDisciplina.Text;
            Professor aluno = new Professor(disciplina, nome, dataNascimento, morada, tipoDePessoa);
            listBox1.Items.Add(aluno);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Pessoa pessoal = (Pessoa)listBox1.Items[index];
            textBoxDados.Text = pessoal.ToString();
        }
        private void buttonVerTipo_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Pessoa pessoal = (Pessoa)listBox1.Items[index];
            labelTipo.Text = pessoal.queTipoDePessoaSou();
            labelTipo.Visible = true;
        }

    }
}
