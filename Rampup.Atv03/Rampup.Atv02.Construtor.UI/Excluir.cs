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
        public List<Conta> ListaDeContas;
        public Excluir()
        {
            InitializeComponent();
        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            int AccountNumber = Convert.ToInt32(txtAccountNumber.Text);

            ListaDeContas.DeleteUser(ListaDeContas, AccountNumber);
        }
    }
}
