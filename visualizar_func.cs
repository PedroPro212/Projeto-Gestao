using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Login
{
    public partial class visualizar_func : Form
    {
        Thread nt1;
        public visualizar_func()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void visualizar_func_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(func);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void func()
        {
            Application.Run(new funcionario());
        }
    }
}
