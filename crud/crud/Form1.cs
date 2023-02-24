
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textNome.Text.Equals("") && !textEmail.Text.Equals("") && !textCpf.Text.Equals("") && !textUsuario.Text.Equals("") && !textSenha.Text.Equals(""))
                {
                    cadastro cadUsuario = new cadastro();
                    cadUsuario.Nome = textNome.Text;
                    cadUsuario.Email = textEmail.Text;
                    cadUsuario.Cpf = textCpf.Text;
                    cadUsuario.Usuario = textUsuario.Text;
                    cadUsuario.Senha = textSenha.Text;

                    if(cadUsuario.CadastrarUsuario()) 
                    {
                        MessageBox.Show($"o usuario {cadUsuario.Nome} foi cadastrado");
                    }
                    else
                    {
                        MessageBox.Show("nao foi possivel cadastrar usuario");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao cadastrar usuario: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textCpf.Text.Equals(""))
                {
                    cadastro cadUsuario = new cadastro();
                    cadUsuario.Cpf = textCpf.Text;

                    MySqlDataReader reader = cadUsuario.localizarUsuario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblId.Text = reader["id"].ToString();
                            textNome.Text = reader["nome"].ToString();
                            textEmail.Text = reader["email"].ToString();
                            textUsuario.Text = reader["usuario"].ToString();
                            textSenha.Text = reader["senha"].ToString();
                        
                        }
                        else
                        {
                            MessageBox.Show("usuario nao encontrado");
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("usuario nao encontrado");
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF para realizar a pesquisa!");
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar usuario: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
    
