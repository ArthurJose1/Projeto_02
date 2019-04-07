namespace Projeto_02
{
    partial class frmMaterTurma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtNumeroSala = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manter Turmas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Turma: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Localização: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número da Sala: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Curso: ";
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(123, 92);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(114, 20);
            this.txtNomeTurma.TabIndex = 6;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(118, 164);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(166, 20);
            this.txtLocalizacao.TabIndex = 7;
            // 
            // txtNumeroSala
            // 
            this.txtNumeroSala.Location = new System.Drawing.Point(338, 92);
            this.txtNumeroSala.Name = "txtNumeroSala";
            this.txtNumeroSala.Size = new System.Drawing.Size(119, 20);
            this.txtNumeroSala.TabIndex = 8;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(118, 125);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(334, 20);
            this.txtCurso.TabIndex = 9;
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(25, 237);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(413, 81);
            this.dgvTurma.TabIndex = 10;
            this.dgvTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(378, 158);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 26);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(290, 158);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 26);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pesquisar por nome: ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(28, 30);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // frmMaterTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 340);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNumeroSala);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.txtNomeTurma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMaterTurma";
            this.Text = "Manter Turmas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtNumeroSala;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
    }
}