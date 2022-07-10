using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;

namespace Login
{
    public partial class cadastrar : Form
    { 
        // String de conexão com banco de dados
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOPPEDRO\SQLEXPRESS;Initial Catalog=Gestao;Integrated Security=True");
        Thread nt1;
        Bitmap bmp;
        public cadastrar()
        {
            InitializeComponent();
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criamos a string de inserção Sql
            string sql = "INSERT INTO CadastrarProduto(Nome, PrecoUn, Data, Categoria, Quantidade, QComprou, Imagem) VALUES (@Nome, @PrecoUn, @Data, @Categoria, @Quantidade, @QComprou, @Imagem)";
            
            MemoryStream memory = new MemoryStream();
            //bmp.Save(memory, ImageFormat.Bmp);

            //bmp.Save(memory, ImageFormat.Bmp);
            byte[] foto = memory.ToArray();


            try
            {
                //Cria um objeto do tipo comando passando com parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere os dados os dados do TextBox no comando sql
                c.Parameters.Add(new SqlParameter("@Nome", this.txt_nome.Text));
                c.Parameters.Add(new SqlParameter("@PrecoUn", this.txt_preco.Text));
                c.Parameters.Add(new SqlParameter("@Data", this.txt_data.Text));
                c.Parameters.Add(new SqlParameter("@Categoria", this.txt_categ.Text));
                c.Parameters.Add(new SqlParameter("@Quantidade", this.txt_quant.Text));
                c.Parameters.Add(new SqlParameter("@QComprou", this.txt_quem.Text));

                SqlParameter imagem = new SqlParameter("@Imagem", SqlDbType.Binary);

                imagem.Value = foto;

                c.Parameters.Add(imagem);

                //Abrir a conexão com banco de dados
                conn.Open();

                //Executa o comando sql no banco de dados
                c.ExecuteNonQuery();

                //Fechamos a conexão 
                conn.Close();

                MessageBox.Show("Enviado com sucesso!");

                txt_nome.Text = "";
                txt_preco.Text = "";
                txt_data.Text = "";
                txt_categ.Text = "";
                txt_quant.Text = "";
                txt_quem.Text = "";
                picture_image.Image = null;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(prod);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }
        private void prod()
        {
            Application.Run(new home());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            // Deletar

            txtid.Enabled = true;

            try
            {
                string sql = "DELETE FROM CadastrarProduto WHERE id=" + txtid.Text;

                conn.Open();

                SqlCommand c = new SqlCommand(sql, conn);
                c.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Exluido com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                conn.Close();
               
                txtid.Text = "";
                txt_nome.Text = "";
                txt_preco.Text = "";
                txt_data.Text = "";
                txt_categ.Text = "";
                txt_quant.Text = "";
                txt_quem.Text = "";
                txtid.Text = "";
            }
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            //Pesquisar

            txtid.Enabled = false;

            string sql = "SELECT * FROM CadastrarProduto WHERE id=" + txtid.Text;

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                rdr.Read();

                if (rdr.HasRows)
                {
                    txt_nome.Text = rdr[1].ToString();
                    txt_preco.Text = rdr[2].ToString();
                    txt_data.Text = rdr[3].ToString();
                    txt_categ.Text = rdr[4].ToString();
                    txt_quant.Text = rdr[5].ToString();
                    txt_quem.Text = rdr[6].ToString();
                    try
                    {
                        byte[] imagem = (byte[])rdr[7];
                        if (imagem == null)
                        picture_image.Image = null;

                        else
                        {
                            MemoryStream memory = new MemoryStream(imagem);

                            picture_image.Image = Image.FromStream(memory);
                        }
                    }
                    catch
                    {
                        
                    }

                }
                
            }
            conn.Close();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            txtid.Enabled = true;

            txtid.Text = "";
            txt_nome.Text = "";
            txt_preco.Text = "";
            txt_data.Text = "";
            txt_categ.Text = "";
            txt_quant.Text = "";
            txt_quem.Text = "";
            picture_image.Image = null;
        }

        private void button_alterar_Click(object sender, EventArgs e)
        {
            txtid.Enabled = true;

            try
            {
                SqlCommand comm = conn.CreateCommand();
                conn.Open();
                comm.CommandText = "UPDATE [dbo].[CadastrarProduto] SET [Nome] ='" + txt_nome.Text + "',[PrecoUn] ='" + txt_preco.Text + "',[Data] ='" + txt_data.Text + "',[Categoria] ='" + txt_categ.Text + "',[Quantidade] ='" + txt_quant.Text + "',[QComprou] ='" + txt_quem.Text + "',[Imagem] = CAST('" +  picture_image + "'AS VARCHAR(300)) WHERE [id] =" + txtid.Text;

                comm.ExecuteNonQuery();
                MessageBox.Show("Foi atualizado com sucesso!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                conn.Close();

                txtid.Text = "";
                txt_nome.Text = "";
                txt_preco.Text = "";
                txt_data.Text = "";
                txt_categ.Text = "";
                txt_quant.Text = "";
                txt_quem.Text = "";
                picture_image.Image = null;
                
            }
        }
        private void button_inserir_img_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;

                bmp = new Bitmap(nome);

                picture_image.Image = bmp;
            }
        }
    }
}
