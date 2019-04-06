using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Projeto_02
{
    class ClasseTurma
    {
        public int ID_Turma { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int NumeroSala { get; set; }
        public string Localizacao { get; set; }

        ClasseAcessoBD bd = new ClasseAcessoBD();


        public bool InserirTurma()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Turma (Nome, Curso,Numero_Sala,Localizacao) VALUES ('{0}','{1}',{2},'{3}')", Nome,Curso,NumeroSala,Localizacao));
                bd.Conectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir turma. ");
            }
        }



        public DataTable RetornarTurmas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Turma"));
            bd.Desconectar();

            return dt;
        }



        public bool EditarTurma(int idTurmaClicada)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Turma SET Nome = '{0}' , Curso = '{1}',Numero_Sala = {2},Localizacao = '{3}' WHERE ID_Turma = {4}", Nome, Curso, NumeroSala, Localizacao, idTurmaClicada));
                bd.Conectar();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao tentar editar.");
            }
        }


    }
}
