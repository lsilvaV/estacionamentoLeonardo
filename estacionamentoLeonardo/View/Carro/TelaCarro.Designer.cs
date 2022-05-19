
namespace estacionamentoLeonardo.View.Carro
{
    partial class TelaCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCarro));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cbxCarro = new System.Windows.Forms.ComboBox();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(107, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Carro";
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblCarro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCarro.Location = new System.Drawing.Point(104, 100);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(47, 14);
            this.lblCarro.TabIndex = 1;
            this.lblCarro.Text = "Carro:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCor.Location = new System.Drawing.Point(117, 134);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 14);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "Cor:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(102, 168);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 14);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlaca.Location = new System.Drawing.Point(106, 202);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(45, 14);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // cbxCarro
            // 
            this.cbxCarro.FormattingEnabled = true;
            this.cbxCarro.Items.AddRange(new object[] {
            "AUDI 80",
            "AUDI A1",
            "AUDI A3",
            "AUDI A4 ",
            "AUDI A5\t\t",
            "AUDI A6",
            "AUDI A7\t",
            "AUDI A8",
            "AUDI AVANT ALLROAD\t\t",
            "AUDI E-TRON",
            "AUDI E-TRON GT\t",
            "AUDI Q3",
            "AUDI Q5\t\t",
            "AUDI Q7",
            "AUDI Q8\t\t",
            "AUDI R8",
            "AUDI RS Q3\t\t",
            "AUDI RS Q8",
            "AUDI RS3\t",
            "AUDI RS4 ",
            "AUDI RS5\t\t",
            "AUDI RS6",
            "AUDI RS7\t\t",
            "AUDI S3",
            "AUDI S4\t\t",
            "AUDI S5 ",
            "AUDI S6\t",
            "AUDI S7",
            "AUDI S8\t",
            "AUDI SQ5",
            "AUDI TT\t\t",
            "AUDI TTS",
            "BMW 1M",
            "BMW i3\t\t",
            "BMW i8 ",
            "BMW IX\t\t",
            "BMW M2 ",
            "BMW M3\t\t",
            "BMW M340I",
            "BMW M4\t\t",
            "BMW M440I",
            "BMW M5\t\t",
            "BMW M6",
            "BMW SÉRIE 1\t\t",
            "BMW SÉRIE 2",
            "BMW SÉRIE 2 ACTIVE TOURER\t\t",
            "BMW SÉRIE 3 ",
            "BMW SÉRIE 4\t\t",
            "BMW SÉRIE 5",
            "BMW SÉRIE 7\t\t",
            "BMW SÉRIE 8 ",
            "BMW X1\t\t",
            "BMW X2",
            "BMW X3\t\t",
            "BMW X4",
            "BMW X5\t",
            "BMW X6\t",
            "BMW X7\t",
            "BMW Z3\t\t",
            "BMW Z4 ",
            "BMW Z8\t",
            "CHEVROLET AGILE ",
            "CHEVROLET ASTRA",
            "CHEVROLET BLAZER\t",
            "CHEVROLET BOLT",
            "CHEVROLET CAMARO\t\t",
            "CHEVROLET CAPTIVA",
            "CHEVROLET CELTA\t",
            "CHEVROLET COBALT",
            "CHEVROLET CORSA\t",
            "CHEVROLET CORSA CLASSIC ",
            "CHEVROLET CORSA HATCH\t",
            "CHEVROLET CORSA PICAPE",
            "CHEVROLET CORSA SEDÃ\t",
            "CHEVROLET CORSA WAGON",
            "CHEVROLET CRUZE\t",
            "CHEVROLET CRUZE SPORT6",
            "CHEVROLET EQUINOX\t\t",
            "CHEVROLET IPANEMA",
            "CHEVROLET JOY\t\t",
            "CHEVROLET JOY PLUS ",
            "CHEVROLET KADETT\t",
            "CHEVROLET MALIBU ",
            "CHEVROLET MERIVA\t\t",
            "CHEVROLET MONTANA ",
            "CHEVROLET MONZA\t",
            "CHEVROLET OMEGA",
            "CHEVROLET ONIX\t\t",
            "CHEVROLET ONIX PLUS",
            "CHEVROLET PRISMA\t\t",
            "CHEVROLET S10",
            "CHEVROLET S-10\t\t",
            "CHEVROLET SILVERADO",
            "CHEVROLET SONIC\t\t",
            "CHEVROLET SPACE VAN",
            "CHEVROLET SPIN\t\t",
            "CHEVROLET SUPREMA",
            "CHEVROLET TIGRA\t\t",
            "CHEVROLET TRACKER",
            "CHEVROLET TRAILBLAZER\t",
            "CHEVROLET VECTRA",
            "CHEVROLET ZAFIRA\t"});
            this.cbxCarro.Location = new System.Drawing.Point(157, 97);
            this.cbxCarro.Name = "cbxCarro";
            this.cbxCarro.Size = new System.Drawing.Size(191, 22);
            this.cbxCarro.TabIndex = 5;
            // 
            // cbxCor
            // 
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
            this.cbxCor.Location = new System.Drawing.Point(157, 131);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(191, 22);
            this.cbxCor.TabIndex = 6;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "AUDI",
            "BMW",
            "CHEVROLET"});
            this.cbxMarca.Location = new System.Drawing.Point(157, 165);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(191, 22);
            this.cbxMarca.TabIndex = 7;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Location = new System.Drawing.Point(157, 199);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(191, 22);
            this.tbxPlaca.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(254, 233);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.cbxCarro);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCarro";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCarro_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cbxCarro;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Button btnCadastrar;
    }
}