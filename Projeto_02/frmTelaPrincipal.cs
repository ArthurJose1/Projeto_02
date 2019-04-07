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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCadastrarAluno_Click(object sender, EventArgs e)
        {
             frmAluno AbrirAluno = new frmAluno();
            this.Hide();
            AbrirAluno.Show();
        }

        private void BtnManterAluno_Click(object sender, EventArgs e)
        {
            frmManterAlunos AbrirManterAluno = new frmManterAlunos();
            this.Hide();
            AbrirManterAluno.Show();
        }

        private void BtnManterTurma_Click(object sender, EventArgs e)
        {
            frmMaterTurma AbrirManterTurma = new frmMaterTurma();
            this.Hide();
            AbrirManterTurma.Show();
        }

        private void BtnManterCurso_Click(object sender, EventArgs e)
        {
           
            frmManterCurso AbrirCurso = new frmManterCurso();
            this.Hide();
            AbrirCurso.Show();
        }

        private void BtnVisualizarTurma_Click(object sender, EventArgs e)
        {
            frmVisualizarAlunoTurma AbrirVisualizarAlunoTurma = new frmVisualizarAlunoTurma();
            this.Hide();
            AbrirVisualizarAlunoTurma.Show();
        }

        private void BtnManterFuncionario_Click(object sender, EventArgs e)
        {
            
            frmManterFuncionarios AbrirManterFuncionarios = new frmManterFuncionarios();
            this.Hide();
            AbrirManterFuncionarios.Show();
        }
    }
}
