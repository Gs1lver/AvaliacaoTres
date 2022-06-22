namespace AvaliacaoTres
{
    partial class frmMovimento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grpSuperior = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.grpMovimento = new System.Windows.Forms.GroupBox();
            this.grpSuperior.SuspendLayout();
            this.grpMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(18, 46);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(118, 23);
            this.txtConta.TabIndex = 1;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(308, 45);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(118, 23);
            this.txtLimite.TabIndex = 4;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(494, 44);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(118, 23);
            this.txtSaldo.TabIndex = 5;
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdComum.Location = new System.Drawing.Point(166, 24);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(122, 24);
            this.rdComum.TabIndex = 2;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdEspecial.Location = new System.Drawing.Point(166, 49);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(124, 24);
            this.rdEspecial.TabIndex = 3;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConta.Location = new System.Drawing.Point(18, 20);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(71, 20);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Nr. Conta";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimite.Location = new System.Drawing.Point(308, 20);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(50, 20);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(494, 24);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 20);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // grpSuperior
            // 
            this.grpSuperior.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpSuperior.Controls.Add(this.lblSaldo);
            this.grpSuperior.Controls.Add(this.lblLimite);
            this.grpSuperior.Controls.Add(this.lblConta);
            this.grpSuperior.Controls.Add(this.rdEspecial);
            this.grpSuperior.Controls.Add(this.rdComum);
            this.grpSuperior.Controls.Add(this.txtSaldo);
            this.grpSuperior.Controls.Add(this.txtLimite);
            this.grpSuperior.Controls.Add(this.txtConta);
            this.grpSuperior.Location = new System.Drawing.Point(10, 12);
            this.grpSuperior.Name = "grpSuperior";
            this.grpSuperior.Size = new System.Drawing.Size(647, 88);
            this.grpSuperior.TabIndex = 3;
            this.grpSuperior.TabStop = false;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDepositar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepositar.Location = new System.Drawing.Point(22, 127);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(134, 60);
            this.btnDepositar.TabIndex = 6;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.LightCoral;
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSacar.Location = new System.Drawing.Point(176, 127);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(134, 60);
            this.btnSacar.TabIndex = 7;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(504, 127);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 60);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtMovimento
            // 
            this.dtMovimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(12, 45);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(118, 27);
            this.dtMovimento.TabIndex = 9;
            this.dtMovimento.Leave += new System.EventHandler(this.dtMovimento_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(224, 45);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(118, 23);
            this.txtValor.TabIndex = 10;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLancar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLancar.Location = new System.Drawing.Point(494, 37);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(118, 31);
            this.btnLancar.TabIndex = 11;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(12, 22);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 20);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(224, 22);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 20);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor";
            // 
            // grpMovimento
            // 
            this.grpMovimento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpMovimento.Controls.Add(this.lblValor);
            this.grpMovimento.Controls.Add(this.lblData);
            this.grpMovimento.Controls.Add(this.dtMovimento);
            this.grpMovimento.Controls.Add(this.btnLancar);
            this.grpMovimento.Controls.Add(this.txtValor);
            this.grpMovimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMovimento.Location = new System.Drawing.Point(10, 214);
            this.grpMovimento.Name = "grpMovimento";
            this.grpMovimento.Size = new System.Drawing.Size(647, 100);
            this.grpMovimento.TabIndex = 12;
            this.grpMovimento.TabStop = false;
            this.grpMovimento.Text = "MOVIMENTO:";
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.grpMovimento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.grpSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Movimento de Contas";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.grpSuperior.ResumeLayout(false);
            this.grpSuperior.PerformLayout();
            this.grpMovimento.ResumeLayout(false);
            this.grpMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtConta;
        private TextBox txtLimite;
        private TextBox txtSaldo;
        private RadioButton rdComum;
        private RadioButton rdEspecial;
        private Label lblConta;
        private Label lblLimite;
        private Label lblSaldo;
        private GroupBox grpSuperior;
        private Button btnDepositar;
        private Button btnSacar;
        private Button btnSair;
        private DateTimePicker dtMovimento;
        private TextBox txtValor;
        private Button btnLancar;
        private Label lblData;
        private Label lblValor;
        private GroupBox grpMovimento;
    }
}