using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Projeto_02
{
    public partial class frmLogin : Form
    {
        ClasseLogin usuario = new ClasseLogin();
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUÁRIO (EMAIL)")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
                pnUsuario.BackColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO (EMAIL)";
                txtUsuario.ForeColor = Color.DimGray;
                pnUsuario.BackColor = Color.DimGray;

            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                pnSenha.BackColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
                pnSenha.BackColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;

            }
        }

        private void btnAcessar_MouseEnter(object sender, EventArgs e)
        {
            if (btnAcessar.ForeColor == Color.DarkGray)
            {
                btnAcessar.ForeColor = Color.White;
            }
        }

        private void btnAcessar_MouseLeave(object sender, EventArgs e)
        {
            if (btnAcessar.ForeColor == Color.White)
            {
                btnAcessar.ForeColor = Color.DarkGray;
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "" || txtUsuario.Text == "USUÁRIO (EMAIL)") && (txtSenha.Text == "" || txtSenha.Text == "SENHA"))
            {
                MessageBox.Show("Por favor preencher todos os campos!");
            }
            else
            {
                usuario.Email = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
                DataTable dt = usuario.RealizarLogin();

                if (dt.Rows.Count != 0)
                {
                    if ((dt.Rows[0]["Email"].ToString() == usuario.Email) && (dt.Rows[0]["Senha"].ToString() == usuario.Senha))
                    {
                        frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();
                        this.Hide();
                        frmTelaPrincipal.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                }
            }
        }
    }
}
