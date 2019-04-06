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
    public partial class frmAluno : Form
    {

        int idAlunoClicado = 0;

        ClasseAlunos aluno = new ClasseAlunos();

        public frmAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
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
          
                if (aluno.InserirAluno() == true)
                {
                    MessageBox.Show("Aluno cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao tentar inserir.");
                }
            }
        }
    }

