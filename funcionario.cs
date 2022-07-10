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

    public partial class funcionario : Form
    {
        Thread nt1;
        public funcionario()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(CadFun);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void CadFun()
        {
            Application.Run(new CadastroFuncionario());
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(VisFun);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void VisFun()
        {
            Application.Run(new visualizar_func());
        }
    }
}
