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
    public partial class frmManterAlunos : Form
    {
        int idCodigoAluno = 0;
        ClasseAlunos aluno = new ClasseAlunos();

        public frmManterAlunos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPesquisarMatricula.Text != "")
            {
                aluno.IdAluno = int.Parse(txtPesquisarMatricula.Text);

                DataTable dt = aluno.RetornarAluno();

                txtIdAluno.Text = dt.Rows[0]["Id_Aluno"].ToString();
                txtNome.Text = dt.Rows[0]["Nome"].ToString();
                txtRg.Text = dt.Rows[0]["RG"].ToString();
                txtCpf.Text = dt.Rows[0]["CPF"].ToString();
                txtCep.Text = dt.Rows[0]["CEP"].ToString();
                txtCelular.Text = dt.Rows[0]["Celular"].ToString();
                txtEndereco.Text = dt.Rows[0]["Endereco"].ToString();
                txtCidade.Text = dt.Rows[0]["Cidade"].ToString();
                txtBairro.Text = dt.Rows[0]["Bairro"].ToString();
                txtDataNascimento.Text = dt.Rows[0]["Data_Nascimento"].ToString();
                txtNomeResponsavel.Text = dt.Rows[0]["Nome_Responsavel"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtCodigoTurma.Text = dt.Rows[0]["Turma_ID_Turma"].ToString();
                txtNomeTurma.Text = dt.Rows[0]["Nome_Turma"].ToString();

            }
            else
            {
                MessageBox.Show("Insira o RA ou CPF do Aluno.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            idCodigoAluno = int.Parse(txtIdAluno.Text);
            aluno.Nome = txtNome.Text;
            aluno.Rg = txtRg.Text;
            aluno.Cpf = txtCpf.Text;
            aluno.Cep = txtCep.Text;
            aluno.Celular = txtCelular.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Cidade = txtCidade.Text;
            aluno.Bairro = txtBairro.Text;
            aluno.DataNascimento = txtDataNascimento.Text;
            aluno.NomeResponsavel = txtNomeResponsavel.Text;
            aluno.Email = txtEmail.Text;
            aluno.IdTurma = int.Parse(txtCodigoTurma.Text);
            aluno.NomeTurma = txtNomeTurma.Text;

            if (aluno.EditarAluno(idCodigoAluno)==true)
            {
                MessageBox.Show("Dados do Aluno alterado.");
            }
            else
            {
                MessageBox.Show("Erro ao alterar dados do Aluno.");
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
