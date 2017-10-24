using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rampup.Atv02.Construtor.UI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(this);
            cadastro.Show();
            Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
