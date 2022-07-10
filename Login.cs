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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Login
{
    public partial class Login : Form
    {
        
        Thread nt;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOPPEDRO\SQLEXPRESS;Initial Catalog=Gestao;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void botao_entrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM Login WHERE NetId = '" + txt_netid.Text + "'AND Senha = '" + txt_senha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                conn.Close();
            }

            else
            {
                MessageBox.Show("NetID ou senha incorretos!!");
                txt_netid.Text = "";
                txt_senha.Text = "";
            }

            conn.Close();


        }

        private void novoForm()
        {
            Application.Run(new home());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nt = new Thread(novForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novForm()
        {
            Application.Run(new Solicitar());
        }
    }
}
