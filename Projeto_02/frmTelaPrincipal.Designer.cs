namespace Projeto_02
{
    partial class frmTelaPrincipal
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
            this.btnManterAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnManterCurso = new System.Windows.Forms.Button();
            this.btnManterTurma = new System.Windows.Forms.Button();
            this.btnVisualizarTurma = new System.Windows.Forms.Button();
            this.btnManterFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManterAluno
            // 
            this.btnManterAluno.Location = new System.Drawing.Point(176, 129);
            this.btnManterAluno.Name = "btnManterAluno";
            this.btnManterAluno.Size = new System.Drawing.Size(155, 23);
            this.btnManterAluno.TabIndex = 0;
            this.btnManterAluno.Text = "Manter Aluno";
            this.btnManterAluno.UseVisualStyleBackColor = true;
            this.btnManterAluno.Click += new System.EventHandler(this.BtnManterAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(176, 84);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(155, 23);
            this.btnCadastrarAluno.TabIndex = 1;
            this.btnCadastrarAluno.Text = "Cadatrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.BtnCadastrarAluno_Click);
            // 
            // btnManterCurso
            // 
            this.btnManterCurso.Location = new System.Drawing.Point(176, 213);
            this.btnManterCurso.Name = "btnManterCurso";
            this.btnManterCurso.Size = new System.Drawing.Size(155, 23);
            this.btnManterCurso.TabIndex = 2;
            this.btnManterCurso.Text = "Manter Curso";
            this.btnManterCurso.UseVisualStyleBackColor = true;
            this.btnManterCurso.Click += new System.EventHandler(this.BtnManterCurso_Click);
            // 
            // btnManterTurma
            // 
            this.btnManterTurma.Location = new System.Drawing.Point(176, 173);
            this.btnManterTurma.Name = "btnManterTurma";
            this.btnManterTurma.Size = new System.Drawing.Size(155, 23);
            this.btnManterTurma.TabIndex = 3;
            this.btnManterTurma.Text = "Manter Turma";
            this.btnManterTurma.UseVisualStyleBackColor = true;
            this.btnManterTurma.Click += new System.EventHandler(this.BtnManterTurma_Click);
            // 
            // btnVisualizarTurma
            // 
            this.btnVisualizarTurma.Location = new System.Drawing.Point(176, 256);
            this.btnVisualizarTurma.Name = "btnVisualizarTurma";
            this.btnVisualizarTurma.Size = new System.Drawing.Size(155, 23);
            this.btnVisualizarTurma.TabIndex = 4;
            this.btnVisualizarTurma.Text = "Visualizar Turma";
            this.btnVisualizarTurma.UseVisualStyleBackColor = true;
            this.btnVisualizarTurma.Click += new System.EventHandler(this.BtnVisualizarTurma_Click);
            // 
            // btnManterFuncionario
            // 
            this.btnManterFuncionario.Location = new System.Drawing.Point(176, 297);
            this.btnManterFuncionario.Name = "btnManterFuncionario";
            this.btnManterFuncionario.Size = new System.Drawing.Size(155, 23);
            this.btnManterFuncionario.TabIndex = 5;
            this.btnManterFuncionario.Text = "Manter Funcionario";
            this.btnManterFuncionario.UseVisualStyleBackColor = true;
            this.btnManterFuncionario.Click += new System.EventHandler(this.BtnManterFuncionario_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 556);
            this.Controls.Add(this.btnManterFuncionario);
            this.Controls.Add(this.btnVisualizarTurma);
            this.Controls.Add(this.btnManterTurma);
            this.Controls.Add(this.btnManterCurso);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnManterAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManterAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnManterCurso;
        private System.Windows.Forms.Button btnManterTurma;
        private System.Windows.Forms.Button btnVisualizarTurma;
        private System.Windows.Forms.Button btnManterFuncionario;
    }
}