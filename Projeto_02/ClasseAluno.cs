using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projeto_02
{
    class ClasseAluno
    {
        public int IdAluno              { get; set; }
        public string Nome              { get; set; }
        public string Rg                { get; set; }
        public string Cpf               { get; set; }
        public string Cep               { get; set; }
        public float Celular           { get; set; }
        public string Endereco          { get; set; }
        public string Cidade            { get; set; }
        public string Bairro            { get; set; }
        public string DataNascimento    { get; set; }
        public string NomeResponsavel   { get; set; }
        public string Email             { get; set; }
        public int IdTurma              { get; set; }
        public string NomeTurma         { get; set; }

        //Objetos
        ClasseAcessoBD bd = new ClasseAcessoBD();

        public bool InserirAluno()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno (Nome, RG, CPF, Celular, CEP, Endereco, Bairro, Cidade, Data_Nascimento, Nome_Responsavel, Email,Turma_ID_Turma,Nome_Turma) VALUES ('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},'{12}')", Nome,Rg,Cpf,Cep,Celular,Endereco,Cidade,Bairro,DataNascimento,NomeResponsavel,Email,IdTurma,NomeTurma));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir aluno. ");
            }


        }

    }
}
