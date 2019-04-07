using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_02
{
    class ClasseFuncionario
    {

        ClasseAcessoBD bd = new ClasseAcessoBD();

        int IdFuncionario { get; set; }
        string Nome { get; set; }
        string Celular { get; set; }
        string DataNascimento { get; set; }
        string Email { get; set; }
        string Cargo { get; set; }
        string Senha { get; set; }

        public bool InserirFuncionario()
        {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Funcionario (Nome, Celular, Data_Nascimento, Email, Cargo, Senha) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", Nome, Celular, DataNascimento, Email, Cargo, Senha));
                bd.Conectar();
                return true;
        }

        public DataTable RetornarFuncionarios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario"));
            bd.Desconectar();
            return dt;
        }

        public bool EditarFuncionario(int idCodigoFuncionario)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Funcionario SET Nome = '{0}',Celular = '{1}',Data_Nascimento = '{2}',Email = '{3}', Cargo = '{4}',Senha = '{5}' WHERE ID_Funcionario = {6}", Nome, Celular, DataNascimento, Email, Cargo, Senha, idCodigoFuncionario));
            bd.Conectar();
            return true;
        }

        public bool DeletarFuncionario(int idCodigoFuncionario)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE Funcionario WHERE ID_Funcionario = {0}",idCodigoFuncionario));
            bd.Conectar();
            return true;
        }
    }
}
