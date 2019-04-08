using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Projeto_02
{
    class ClasseProfessor
    {
        ClasseAcessoBD bd = new ClasseAcessoBD();

        public int IdProfessor { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdCoordenadorProfessor { get; set; }


        public bool InserirProfessor()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Professor (Nome, Celular, Data_Nascimento, Email, Senha, ID_Coordenador_Professor) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}',{5})", Nome, Celular, DataNascimento, Email,Senha,IdCoordenadorProfessor));
                bd.Conectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir professor. ");
            }
        }

        public DataTable RetornarProfessor()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor"));
            bd.Desconectar();
            return dt;
        }

        public bool DeletarFuncionario(int idCodigoProfessor)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE Professor WHERE ID_Professor = {0}", idCodigoProfessor));
            bd.Conectar();
            return true;
        }


    }
}
