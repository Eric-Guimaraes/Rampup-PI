using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rampup.Atv02.Construtor.CL;

namespace Rampup.Atv02.Construtor.UI
{
    public partial class Cadastro : Form
    {
        List<Conta> ListaDeContas = new List<Conta>();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string NomeTitular;
            int CPF;
            int TipoDeConta;

            CPF = Convert.ToInt32(txtCPF.Text);
            NomeTitular = txtNome.Text;

            if (rdbtnContaCorrente.Checked)
            {
                TipoDeConta = 1;
            }
            else
            {
                TipoDeConta = 2;
            }

            Conta aux = new Conta(NomeTitular, CPF, TipoDeConta, ListaDeContas);
        }
        Index ();
        cadastro.Hide();
    }
}
