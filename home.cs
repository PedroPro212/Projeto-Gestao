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

namespace Login
{
    public partial class home : Form
    {
        Thread nt1;
        public home()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {   
            this.Close();
            nt1 = new Thread(Fun);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }
        private void Fun()
        {
            Application.Run(new funcionario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(Prod);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void Prod()
        {
            Application.Run(new cadastrar());
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(novForm);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void novForm()
        {
            Application.Run(new Login());
        }
    }
}
