using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class frmManterFuncionarios : Form
    {
        ClasseFuncionario Funcionario = new ClasseFuncionario();
        int idCodigoFuncionario = 0;

        public frmManterFuncionarios()
        {
            InitializeComponent();
            dgvFuncionarios.DataSource = Funcionario.RetornarFuncionarios();
        }

        private void DgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCodigoFuncionario = int.Parse(dgvFuncionarios.Rows[e.RowIndex].Cells["ID_Funcionario"].Value.ToString());

            txtNome.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtCelular.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
            txtDataNascimento.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Data_Nascimento"].Value.ToString();
            txtEmail.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txtSenha.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            cbbCargo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario.Nome = txtNome.Text;
            Funcionario.Celular = txtCelular.Text;
            Funcionario.DataNascimento = txtDataNascimento.Text;
            Funcionario.Email = txtEmail.Text;
            Funcionario.Senha = txtSenha.Text;
            Funcionario.Cargo = cbbCargo.Text;

            if (idCodigoFuncionario != 0)
            {
                Funcionario.InserirFuncionario();
                dgvFuncionarios.DataSource = Funcionario.RetornarFuncionarios();
                MessageBox.Show("Funcionário cadastrado com sucesso.");
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Funcionario.Nome = txtNome.Text;
            Funcionario.Celular = txtCelular.Text;
            Funcionario.DataNascimento = txtDataNascimento.Text;
            Funcionario.Email = txtEmail.Text;
            Funcionario.Senha = txtSenha.Text;
            Funcionario.Cargo = cbbCargo.Text;

            if (idCodigoFuncionario != 0)
            {
                Funcionario.EditarFuncionario(idCodigoFuncionario);
                dgvFuncionarios.DataSource = Funcionario.RetornarFuncionarios();
                MessageBox.Show("Funcionário editado com sucesso.");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (idCodigoFuncionario != 0)
            {
                Funcionario.DeletarFuncionario(idCodigoFuncionario);
                dgvFuncionarios.DataSource = Funcionario.RetornarFuncionarios();
                MessageBox.Show("Funcionário Excluido");

            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal AbrirTelaPrincipal = new frmTelaPrincipal();
            this.Hide();
            AbrirTelaPrincipal.Show();
        }
    }
}
