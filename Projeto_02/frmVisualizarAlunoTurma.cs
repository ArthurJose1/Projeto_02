﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//testegit
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


    }
}
