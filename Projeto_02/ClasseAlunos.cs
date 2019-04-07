using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Projeto_02
{
    class ClasseAlunos
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string DataNascimento { get; set; }
        public string NomeResponsavel { get; set; }
        public string Email { get; set; }
        public int IdTurma { get; set; }
        public string NomeTurma { get; set; }

        //Objetos
        ClasseAcessoBD bd = new ClasseAcessoBD();

        public bool InserirAluno()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno (Nome, RG, CPF, Celular, CEP, Endereco, Bairro, Cidade, Data_Nascimento, Nome_Responsavel, Email,Turma_ID_Turma,Nome_Turma) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},'{12}')", Nome, Rg, Cpf, Cep, Celular, Endereco, Bairro, Cidade,  DataNascimento, NomeResponsavel, Email, IdTurma, NomeTurma));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir aluno. ");
            }
        }

        public DataTable RetornarAluno()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE ID_Aluno = {0}",IdAluno));
            bd.Desconectar();
            return dt;
        }


        public bool EditarAluno(int idCodigoAluno)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Aluno SET Nome= '{0}',RG = '{1}',CPF = '{2}',Celular = '{3}',CEP = {4},Endereco = '{5}',Bairro = '{6}',Cidade = '{7}',Data_Nascimento = '{8}',Nome_Responsavel = '{9} ',Email = '{10}',Turma_ID_Turma = {11},Nome_Turma = '{12}' WHERE ID_Aluno = {13};",Nome, Rg, Cpf,  Celular, Cep, Endereco,  Bairro, Cidade, DataNascimento, NomeResponsavel, Email, IdTurma, NomeTurma,idCodigoAluno));
            bd.Desconectar();
            return true;
        }

        public DataTable RetornarAlunoPorTurma(int TurmaDosAlunos)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE Turma_ID_Turma = {0}", TurmaDosAlunos));
            bd.Desconectar();
            return dt;
        }

    }
}
