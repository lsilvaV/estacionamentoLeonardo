
namespace estacionamentoLeonardo.View.Ticket
{
    partial class TelaTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTicket));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(118, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 14);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(72, 138);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(95, 14);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data de Hoje:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlaca.Location = new System.Drawing.Point(63, 165);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 14);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa do Carro:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCor.Location = new System.Drawing.Point(132, 192);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 14);
            this.lblCor.TabIndex = 3;
            this.lblCor.Text = "Cor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(152, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gerar Ticket";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNome.Location = new System.Drawing.Point(167, 108);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(184, 22);
            this.tbxNome.TabIndex = 5;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPlaca.Location = new System.Drawing.Point(168, 162);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(184, 22);
            this.tbxPlaca.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(271, 217);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpData.Location = new System.Drawing.Point(168, 135);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(184, 22);
            this.dtpData.TabIndex = 10;
            // 
            // cbxCor
            // 
            this.cbxCor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Amarelo",
            "Azul",
            "Vermelho",
            "Verde",
            "Rosa",
            "Roxo"});
            this.cbxCor.Location = new System.Drawing.Point(168, 189);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(183, 22);
            this.cbxCor.TabIndex = 11;
            // 
            // TelaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaTicket";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaTicket_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbxCor;
    }
}