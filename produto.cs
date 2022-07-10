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
    public partial class produto : Form
    {
        Thread nt1;
        public produto()
        {
            InitializeComponent();
        }

        private void produto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(hom);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void hom()
        {
            Application.Run(new home());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(cadprod);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void cadprod()
        {
            Application.Run(new cadastrar());
        }
    }
}
