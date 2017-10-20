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
            this.rdbtnContaCorrente = new System.Windows.Forms.RadioButton();
            this.rdbtnPoupanca = new System.Windows.Forms.RadioButton();
            this.labelRadioBtnTipoDeConta = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            // rdbtnContaCorrente
            // 
            this.rdbtnContaCorrente.AutoSize = true;
            this.rdbtnContaCorrente.Location = new System.Drawing.Point(15, 154);
            this.rdbtnContaCorrente.Name = "rdbtnContaCorrente";
            this.rdbtnContaCorrente.Size = new System.Drawing.Size(96, 17);
            this.rdbtnContaCorrente.TabIndex = 4;
            this.rdbtnContaCorrente.TabStop = true;
            this.rdbtnContaCorrente.Text = "Conta Corrente";
            this.rdbtnContaCorrente.UseVisualStyleBackColor = true;
            // 
            // rdbtnPoupanca
            // 
            this.rdbtnPoupanca.AutoSize = true;
            this.rdbtnPoupanca.Location = new System.Drawing.Point(15, 179);
            this.rdbtnPoupanca.Name = "rdbtnPoupanca";
            this.rdbtnPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rdbtnPoupanca.TabIndex = 5;
            this.rdbtnPoupanca.TabStop = true;
            this.rdbtnPoupanca.Text = "Poupança";
            this.rdbtnPoupanca.UseVisualStyleBackColor = true;
            // 
            // labelRadioBtnTipoDeConta
            // 
            this.labelRadioBtnTipoDeConta.AutoSize = true;
            this.labelRadioBtnTipoDeConta.Location = new System.Drawing.Point(23, 138);
            this.labelRadioBtnTipoDeConta.Name = "labelRadioBtnTipoDeConta";
            this.labelRadioBtnTipoDeConta.Size = new System.Drawing.Size(74, 13);
            this.labelRadioBtnTipoDeConta.TabIndex = 6;
            this.labelRadioBtnTipoDeConta.Text = "Tipo de Conta";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(197, 226);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelRadioBtnTipoDeConta);
            this.Controls.Add(this.rdbtnPoupanca);
            this.Controls.Add(this.rdbtnContaCorrente);
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
        private System.Windows.Forms.RadioButton rdbtnContaCorrente;
        private System.Windows.Forms.RadioButton rdbtnPoupanca;
        private System.Windows.Forms.Label labelRadioBtnTipoDeConta;
        private System.Windows.Forms.Button btnConfirm;
    }
}

