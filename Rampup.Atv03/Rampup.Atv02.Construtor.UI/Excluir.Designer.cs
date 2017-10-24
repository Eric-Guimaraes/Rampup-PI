namespace Rampup.Atv02.Construtor.UI
{
    partial class Excluir
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
            this.btnSendValue = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendValue
            // 
            this.btnSendValue.Location = new System.Drawing.Point(98, 124);
            this.btnSendValue.Name = "btnSendValue";
            this.btnSendValue.Size = new System.Drawing.Size(75, 23);
            this.btnSendValue.TabIndex = 7;
            this.btnSendValue.Text = "Enviar";
            this.btnSendValue.UseVisualStyleBackColor = true;
            this.btnSendValue.Click += new System.EventHandler(this.btnSendValue_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(107, 89);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(55, 20);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 73);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(210, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Informe o Numero da Conta a ser excluída:";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSendValue);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lbl);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendValue;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lbl;
    }
}