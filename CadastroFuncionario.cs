using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Login
{
    public partial class CadastroFuncionario : Form
    {
        Thread nt1;
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(menu);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void menu()
        {
            Application.Run(new funcionario());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Criamos a string de conexão
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOPPEDRO\SQLEXPRESS;Initial Catalog=Gestao;Integrated Security=True");

            //Criamos a string de inserção Sql
            string sql = "INSERT INTO Cadastrar_Func(Nome, Data_Nascimento, Data_Contratacao, Salario, CPF, Tel, Email, Cidade_atual) VALUES (@Nome, @Data_Nascimento, @Data_Contratacao, @Salario, @CPF, @Tel, @Email, @Cidade_atual)";

            try
            {
                //Cria um objeto do tipo comando passando com parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere os dados os dados do TextBox no comando sql
                c.Parameters.Add(new SqlParameter("@Nome", this .textBox1.Text));
                c.Parameters.Add(new SqlParameter("@Data_Nascimento", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@Data_Contratacao", this.textBox3.Text));
                c.Parameters.Add(new SqlParameter("@Salario", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@CPF", this.textBox5.Text));
                c.Parameters.Add(new SqlParameter("@Tel", this.textBox6.Text));
                c.Parameters.Add(new SqlParameter("@Email", this.textBox7.Text));
                c.Parameters.Add(new SqlParameter("Cidade_atual", this.textBox8.Text));

                //Abrir a conexão com banco de dados
                conn.Open();

                //Executa o comando sql no banco de dados
                c.ExecuteNonQuery();

                //Fechamos a conexão 
                conn.Close();

                MessageBox.Show("Enviado com sucesso!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
