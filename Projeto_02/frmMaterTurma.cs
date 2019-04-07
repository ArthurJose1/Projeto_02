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
    public partial class frmMaterTurma : Form
    {
        int idTurmaClicada = 0;
        ClasseTurma turma = new ClasseTurma();

        public frmMaterTurma()
        {
            InitializeComponent();
            dgvTurma.DataSource = turma.RetornarTurmas();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            turma.Nome = txtNomeTurma.Text;
            turma.Curso = txtCurso.Text;
            turma.NumeroSala = int.Parse(txtNumeroSala.Text);
            turma.Localizacao = txtLocalizacao.Text;

            if (turma.InserirTurma() == true)
            {
                MessageBox.Show("Turma Registrada.");
                dgvTurma.DataSource = turma.RetornarTurmas();
            }
            else
            {
                MessageBox.Show("Erro ao tentar registrar.");
            }
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurma.Rows[e.RowIndex].Cells["Id_Turma"].Value.ToString() != "")
            {
                idTurmaClicada = int.Parse(dgvTurma.Rows[e.RowIndex].Cells["Id_Turma"].Value.ToString());
            }
            txtNomeTurma.Text = dgvTurma.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtCurso.Text = dgvTurma.Rows[e.RowIndex].Cells["Curso"].Value.ToString();
            txtNumeroSala.Text = dgvTurma.Rows[e.RowIndex].Cells["Numero_Sala"].Value.ToString();
            txtLocalizacao.Text = dgvTurma.Rows[e.RowIndex].Cells["Localizacao"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            turma.Nome = txtNomeTurma.Text;
            turma.Curso = txtCurso.Text;
            turma.NumeroSala = int.Parse(txtNumeroSala.Text);
            turma.Localizacao = txtLocalizacao.Text;

            if (turma.EditarTurma(idTurmaClicada) == true)
            {
                MessageBox.Show("Dados da turma alterados.");
                dgvTurma.DataSource = turma.RetornarTurmas();
            }
            else
            {
                MessageBox.Show("Erro ao tentar editar.");
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
