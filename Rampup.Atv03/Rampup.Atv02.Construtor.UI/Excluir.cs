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
    public partial class Excluir : Form
    {
        Form backIndex = new Form();
        List<Conta> ListaDeContas = new List<Conta>();
        
        public Excluir(Form backIndex)
        {
            InitializeComponent();
            this.backIndex = backIndex;
        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            int AccountNumber = Convert.ToInt32(txtAccountNumber.Text);

            ListaDeContas[AccountNumber].DeleteUser(ListaDeContas, AccountNumber);

            backIndex.Show();
            Close();
        }
    }
}
