using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//testegit
//teste git 2
//teste git 33
namespace Projeto_02
{
    public partial class frmVisualizarAlunoTurma : Form
    {
        ClasseTurma turma = new ClasseTurma();
        ClasseAlunos aluno = new ClasseAlunos();

        public frmVisualizarAlunoTurma()
        {
            InitializeComponent();
            dgvTurma.DataSource = turma.RetornarTurmas();
        }
        int TurmaDosAlunos = 0;
        
        public void DgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurma.Rows[e.RowIndex].Cells["Id_Turma"].Value.ToString() != "")
            {
                TurmaDosAlunos = int.Parse(dgvTurma.Rows[e.RowIndex].Cells["Id_Turma"].Value.ToString());
                dgvAlunos.DataSource = aluno.RetornarAlunoPorTurma(TurmaDosAlunos);
            }
        }

}

}
