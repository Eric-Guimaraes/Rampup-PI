﻿namespace DeleteUser
{
    partial class DeleteUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSendValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMenuStrip
            // 
            this.txtMenuStrip.Name = "txtMenuStrip";
            this.txtMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 73);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(210, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Informe o Numero da Conta a ser excluída:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(107, 89);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(55, 20);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // btnSendValue
            // 
            this.btnSendValue.Location = new System.Drawing.Point(98, 124);
            this.btnSendValue.Name = "btnSendValue";
            this.btnSendValue.Size = new System.Drawing.Size(75, 23);
            this.btnSendValue.TabIndex = 4;
            this.btnSendValue.Text = "Enviar";
            this.btnSendValue.UseVisualStyleBackColor = true;
            this.btnSendValue.Click += new System.EventHandler(this.btnSendValue_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSendValue);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lbl);
            this.Name = "DeleteUser";
            this.Text = "Excluir Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip txtMenuStrip;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnSendValue;
    }
}

