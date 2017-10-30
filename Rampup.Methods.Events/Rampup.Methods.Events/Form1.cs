using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rampup.Methods.Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Button b = new Button();

            b.Parent = this;
            b.Text = "Botão Gerado em tempo de execução.";

            b.Location = new Point(22,100);

            b.Size = new Size(100, 100);

            b.Click += B_Click;
        }

        private void B_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
