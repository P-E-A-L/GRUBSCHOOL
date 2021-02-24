namespace GRUBSCHOOL.Apresentation.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new PEALComponents.Ferramentas.DataGridView();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.BloquarBotoes = false;
            this.dataGridView1.BotaoAlterarIndex = 0;
            this.dataGridView1.BotaoDetalhesIndex = 0;
            this.dataGridView1.BotaoRemoverIndex = 0;
            this.dataGridView1.ColunaID = "ID";
            this.dataGridView1.DataSource = null;
            this.dataGridView1.HabilitarBotaoAlterar = false;
            this.dataGridView1.HabilitarBotaoDetalhes = false;
            this.dataGridView1.HabilitarBotaoRemover = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OcultarBotoes = false;
            this.dataGridView1.OcultarTodasColunas = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PEALComponents.Ferramentas.DataGridView dataGridView1;
    }
}

