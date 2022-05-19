
namespace estacionamentoLeonardo.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArquivo,
            this.btnCliente,
            this.btnCarro,
            this.btnTicket,
            this.btnSobre});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(464, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnArquivo
            // 
            this.btnArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair});
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(66, 20);
            this.btnArquivo.Text = "Arquivo";
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(63, 20);
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCarro
            // 
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(54, 20);
            this.btnCarro.Text = "Carro";
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(55, 20);
            this.btnTicket.Text = "Ticket";
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(56, 20);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Estacionamento";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnArquivo;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnCliente;
        private System.Windows.Forms.ToolStripMenuItem btnCarro;
        private System.Windows.Forms.ToolStripMenuItem btnTicket;
        private System.Windows.Forms.ToolStripMenuItem btnSobre;
    }
}