﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteUser
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnSendValue_Click(object sender, EventArgs e)
        {
            int NumberAccount;

            NumberAccount = Convert.ToInt32(txtAccountNumber);
        }
    }
}
