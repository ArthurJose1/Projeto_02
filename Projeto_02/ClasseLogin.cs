using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_02
{
    class ClasseLogin
    {
        ClasseAcessoBD bd = new ClasseAcessoBD();

        public int ID_Diretor { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        public DataTable RealizarLogin()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT Email, Senha FROM Diretor WHERE Email LIKE '{0}' AND Senha LIKE '{1}'", Email, Senha));
            bd.Desconectar();
            return dt;
        }
    }
}
