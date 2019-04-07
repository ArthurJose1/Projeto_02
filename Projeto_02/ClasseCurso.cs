using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_02
{
    class ClasseCurso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public float Preco { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string Descricao { get; set; }

        ClasseAcessoBD bd = new ClasseAcessoBD();

        public bool InserirCurso()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Curso (Nome, Duracao, Preco, Data_Inicio, Data_Fim,Descricao) VALUES ('{0}', '{1}', {2}, '{3}', '{4}','{5}')", Nome, Duracao, Preco, DataInicio, DataFim,Descricao));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir curso. ");
            }
        }
        
        public DataTable RetornarCurso()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Curso"));
            bd.Desconectar();
            return dt;
        }
        public bool EditarCurso(int idCodigoCurso)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Curso SET Nome = '{0}', Duracao = '{1}',Preco = {2}, Data_Inicio = '{3}', Data_Fim = '{4}',Descricao = '{5}' WHERE ID_Curso = {6}", Nome, Duracao, Preco, DataInicio, DataFim,Descricao,idCodigoCurso));
            bd.Desconectar();
            return true;
        }
        public bool DeletarCurso(int idCodigoCurso)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE Curso WHERE ID_Curso = {0};",idCodigoCurso));
            bd.Desconectar();
            return true;
        }
    }
}
