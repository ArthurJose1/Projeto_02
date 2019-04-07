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
    public partial class frmManterCurso : Form
    {
        ClasseCurso Curso = new ClasseCurso();
        int idCodigoCurso = 0;

        public frmManterCurso()
        {
            InitializeComponent();
            dgvCurso.DataSource = Curso.RetornarCurso();
        }

        private void DgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurso.Rows[e.RowIndex].Cells["Id_Curso"].Value.ToString() != "")
            {
                idCodigoCurso = int.Parse(dgvCurso.Rows[e.RowIndex].Cells["Id_Curso"].Value.ToString());
            }
            txtNome.Text = dgvCurso.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtDuracao.Text = dgvCurso.Rows[e.RowIndex].Cells["Duracao"].Value.ToString();
            txtDataInicio.Text = dgvCurso.Rows[e.RowIndex].Cells["Data_Inicio"].Value.ToString();
            txtDataFim.Text = dgvCurso.Rows[e.RowIndex].Cells["Data_Fim"].Value.ToString();
            txtPreco.Text = dgvCurso.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
            txtDescricao.Text = dgvCurso.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
        }

        //Cadastro do Curso, coleta informações da text.box e chama o método de cadastro
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Curso.Nome = txtNome.Text;
            Curso.Duracao = txtDuracao.Text;
            Curso.Preco = int.Parse(txtPreco.Text);
            Curso.Descricao = txtDescricao.Text;
            Curso.DataInicio = txtDataInicio.Text;
            Curso.DataFim = txtDataFim.Text;

            if (Curso.InserirCurso() == true)
            {
                dgvCurso.DataSource = Curso.RetornarCurso();
                MessageBox.Show("Curso Registrado.");
            }
            else
            {
                MessageBox.Show("Erro ao tentar registrar.");
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(idCodigoCurso != 0)
            {
                Curso.DeletarCurso(idCodigoCurso);
                dgvCurso.DataSource = Curso.RetornarCurso();
                MessageBox.Show("Curso excluido com sucesso.");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Curso.Nome = txtNome.Text;
            Curso.Duracao = txtDuracao.Text;
            Curso.Preco = int.Parse(txtPreco.Text);
            Curso.Descricao = txtDescricao.Text;
            Curso.DataInicio = txtDataInicio.Text;
            Curso.DataFim = txtDataFim.Text;

            if (idCodigoCurso != 0)
            {
                Curso.EditarCurso(idCodigoCurso);
                dgvCurso.DataSource = Curso.RetornarCurso();
                MessageBox.Show("Curso editado com sucesso.");
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
