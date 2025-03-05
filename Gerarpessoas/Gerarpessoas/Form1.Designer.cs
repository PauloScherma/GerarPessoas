namespace Gerarpessoas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.pontuar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxDificuldade = new System.Windows.Forms.TextBox();
            this.textBoxNAluno = new System.Windows.Forms.TextBox();
            this.adicionarAluno = new System.Windows.Forms.Button();
            this.adicionarAlunoEspecial = new System.Windows.Forms.Button();
            this.adicionarProfessor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxDados = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonVerTipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxNome
            // 
            resources.ApplyResources(this.textBoxNome, "textBoxNome");
            this.textBoxNome.Name = "textBoxNome";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TodayDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Adicionar
            // 
            resources.ApplyResources(this.Adicionar, "Adicionar");
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            // 
            // pontuar
            // 
            resources.ApplyResources(this.pontuar, "pontuar");
            this.pontuar.Name = "pontuar";
            this.pontuar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxCurso
            // 
            resources.ApplyResources(this.textBoxCurso, "textBoxCurso");
            this.textBoxCurso.Name = "textBoxCurso";
            // 
            // textBoxDisciplina
            // 
            resources.ApplyResources(this.textBoxDisciplina, "textBoxDisciplina");
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            // 
            // textBoxDificuldade
            // 
            resources.ApplyResources(this.textBoxDificuldade, "textBoxDificuldade");
            this.textBoxDificuldade.Name = "textBoxDificuldade";
            // 
            // textBoxNAluno
            // 
            resources.ApplyResources(this.textBoxNAluno, "textBoxNAluno");
            this.textBoxNAluno.Name = "textBoxNAluno";
            // 
            // adicionarAluno
            // 
            resources.ApplyResources(this.adicionarAluno, "adicionarAluno");
            this.adicionarAluno.Name = "adicionarAluno";
            this.adicionarAluno.UseVisualStyleBackColor = true;
            this.adicionarAluno.Click += new System.EventHandler(this.adicionarAluno_Click);
            // 
            // adicionarAlunoEspecial
            // 
            resources.ApplyResources(this.adicionarAlunoEspecial, "adicionarAlunoEspecial");
            this.adicionarAlunoEspecial.Name = "adicionarAlunoEspecial";
            this.adicionarAlunoEspecial.UseVisualStyleBackColor = true;
            this.adicionarAlunoEspecial.Click += new System.EventHandler(this.adicionarAlunoEspecial_Click);
            // 
            // adicionarProfessor
            // 
            resources.ApplyResources(this.adicionarProfessor, "adicionarProfessor");
            this.adicionarProfessor.Name = "adicionarProfessor";
            this.adicionarProfessor.UseVisualStyleBackColor = true;
            this.adicionarProfessor.Click += new System.EventHandler(this.adicionarProfessor_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // labelTipo
            // 
            resources.ApplyResources(this.labelTipo, "labelTipo");
            this.labelTipo.Name = "labelTipo";
            // 
            // textBoxDados
            // 
            resources.ApplyResources(this.textBoxDados, "textBoxDados");
            this.textBoxDados.Name = "textBoxDados";
            // 
            // textBoxMorada
            // 
            resources.ApplyResources(this.textBoxMorada, "textBoxMorada");
            this.textBoxMorada.Name = "textBoxMorada";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // buttonVerTipo
            // 
            resources.ApplyResources(this.buttonVerTipo, "buttonVerTipo");
            this.buttonVerTipo.Name = "buttonVerTipo";
            this.buttonVerTipo.UseVisualStyleBackColor = true;
            this.buttonVerTipo.Click += new System.EventHandler(this.buttonVerTipo_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonVerTipo);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDados);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.adicionarProfessor);
            this.Controls.Add(this.adicionarAlunoEspecial);
            this.Controls.Add(this.adicionarAluno);
            this.Controls.Add(this.textBoxNAluno);
            this.Controls.Add(this.textBoxDificuldade);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pontuar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button pontuar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.TextBox textBoxDificuldade;
        private System.Windows.Forms.TextBox textBoxNAluno;
        private System.Windows.Forms.Button adicionarAluno;
        private System.Windows.Forms.Button adicionarAlunoEspecial;
        private System.Windows.Forms.Button adicionarProfessor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxDados;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVerTipo;
    }
}

