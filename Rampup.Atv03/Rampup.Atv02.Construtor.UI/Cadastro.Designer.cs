namespace Rampup.Atv02.Construtor.UI
{
    partial class Cadastro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label_txtNome = new System.Windows.Forms.Label();
            this.label_txtCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label_txtNome
            // 
            this.label_txtNome.AutoSize = true;
            this.label_txtNome.Location = new System.Drawing.Point(12, 43);
            this.label_txtNome.Name = "label_txtNome";
            this.label_txtNome.Size = new System.Drawing.Size(82, 13);
            this.label_txtNome.TabIndex = 1;
            this.label_txtNome.Text = "Nome Completo";
            // 
            // label_txtCPF
            // 
            this.label_txtCPF.AutoSize = true;
            this.label_txtCPF.Location = new System.Drawing.Point(12, 88);
            this.label_txtCPF.Name = "label_txtCPF";
            this.label_txtCPF.Size = new System.Drawing.Size(27, 13);
            this.label_txtCPF.TabIndex = 3;
            this.label_txtCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 104);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Completo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_txtCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label_txtNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label_txtNome;
        private System.Windows.Forms.Label label_txtCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

