namespace Projeto_02
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnLogo = new System.Windows.Forms.Panel();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.pnSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAvisoUsuario = new System.Windows.Forms.Label();
            this.lblAvisoSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(285, 345);
            this.pnLogo.TabIndex = 0;
            this.pnLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnLogo_MouseDown);
            // 
            // picFechar
            // 
            this.picFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFechar.Image = ((System.Drawing.Image)(resources.GetObject("picFechar.Image")));
            this.picFechar.Location = new System.Drawing.Point(782, 10);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(24, 24);
            this.picFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFechar.TabIndex = 1;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(745, 10);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(24, 24);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimizar.TabIndex = 2;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitle.Location = new System.Drawing.Point(510, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Black;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(364, 98);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(401, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "USUÁRIO (EMAIL)";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.DimGray;
            this.pnUsuario.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pnUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.pnUsuario.Location = new System.Drawing.Point(364, 124);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(401, 1);
            this.pnUsuario.TabIndex = 5;
            // 
            // pnSenha
            // 
            this.pnSenha.BackColor = System.Drawing.Color.DimGray;
            this.pnSenha.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pnSenha.ForeColor = System.Drawing.Color.DimGray;
            this.pnSenha.Location = new System.Drawing.Point(364, 178);
            this.pnSenha.Name = "pnSenha";
            this.pnSenha.Size = new System.Drawing.Size(401, 1);
            this.pnSenha.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Black;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.Location = new System.Drawing.Point(364, 152);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(401, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAcessar.Location = new System.Drawing.Point(373, 249);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(383, 36);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "ACESSAR";
            this.btnAcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            this.btnAcessar.MouseEnter += new System.EventHandler(this.btnAcessar_MouseEnter);
            this.btnAcessar.MouseLeave += new System.EventHandler(this.btnAcessar_MouseLeave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(456, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(214, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu a senha? Clique Aqui!";
            // 
            // lblAvisoUsuario
            // 
            this.lblAvisoUsuario.AutoSize = true;
            this.lblAvisoUsuario.Enabled = false;
            this.lblAvisoUsuario.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoUsuario.Location = new System.Drawing.Point(361, 128);
            this.lblAvisoUsuario.Name = "lblAvisoUsuario";
            this.lblAvisoUsuario.Size = new System.Drawing.Size(0, 15);
            this.lblAvisoUsuario.TabIndex = 8;
            this.lblAvisoUsuario.Visible = false;
            // 
            // lblAvisoSenha
            // 
            this.lblAvisoSenha.AutoSize = true;
            this.lblAvisoSenha.Enabled = false;
            this.lblAvisoSenha.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoSenha.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoSenha.Location = new System.Drawing.Point(361, 182);
            this.lblAvisoSenha.Name = "lblAvisoSenha";
            this.lblAvisoSenha.Size = new System.Drawing.Size(0, 15);
            this.lblAvisoSenha.TabIndex = 9;
            this.lblAvisoSenha.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(823, 345);
            this.Controls.Add(this.lblAvisoSenha);
            this.Controls.Add(this.lblAvisoUsuario);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.pnSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pnUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.pnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Panel pnSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblAvisoUsuario;
        private System.Windows.Forms.Label lblAvisoSenha;
    }
}