using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    internal class cadastro
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string usuario;
        private string senha;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
         
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        
        //metodo cadastro
        public bool CadastrarUsuario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.server);
                MySqlConexaoBanco.Open();

                string insert = $" insert into crud (nome,email,cpf,usuario,senha) values ('{Nome}','{Email}','{Cpf}','{Usuario}','{Senha}')";

                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem para caso erro no cadastro
                //erro ligado ao bd
                MessageBox.Show("Erro no BD - método cadastrar" + ex.Message);
                return false;   
            }
        }
            
        public MySqlDataReader localizarUsuario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.server);
                MySqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf, usuario, senha from crud where cpf = '{Cpf}';";
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no BD - metodo localizarUsuario: " + ex.Message);
                return null;
            }
        }
    }
}
