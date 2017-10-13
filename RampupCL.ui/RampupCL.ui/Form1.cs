using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RampupCL;

namespace RampupCL.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você Clicou em Salvar.");
        }*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.RE = Convert.ToInt32(txtRE.Text);
            stu.Name = txtName.Text;
            stu.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
            stu.CPF = Convert.ToInt32(txtCPF.Text);

            MessageBox.Show("Aluno com RE " + stu.RE + " cadastrado com Sucesso.");
        }
    }
}
