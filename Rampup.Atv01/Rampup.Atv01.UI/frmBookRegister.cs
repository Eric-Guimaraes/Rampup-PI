using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rampup.Atv01.Model;

namespace Rampup.Atv01.UI
{
    public partial class frmBookRegister : Form
    {
        public frmBookRegister()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.PublishDate = Convert.ToDateTime(DatePickerPublishTime.Text);
            book.ID = 0;

            MessageBox.Show("O livro " + book.Title + " foi cadastrado com sucesso." +
                "\n\n ID: " + book.ID +
                "\n Autor: "+ book.Author +
                "\n Data de Publicação: " + book.PublishDate +
                "\n Ano de Publicação: " + book.PublishDate.Year +
                "\n Mês de Publicação: " + book.PublishDate.Month);
        }
    }
}
