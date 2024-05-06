namespace OttavaApp
{
    partial class FrmCategorie
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
            menuStrip1 = new MenuStrip();
            mnuAggiungi = new ToolStripMenuItem();
            mnuModifica = new ToolStripMenuItem();
            mnuCancella = new ToolStripMenuItem();
            lstCategorie = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAggiungi, mnuModifica, mnuCancella });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(524, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAggiungi
            // 
            mnuAggiungi.Name = "mnuAggiungi";
            mnuAggiungi.Size = new Size(131, 38);
            mnuAggiungi.Text = "Aggiungi";
            mnuAggiungi.Click += mnuAggiungi_Click;
            // 
            // mnuModifica
            // 
            mnuModifica.Name = "mnuModifica";
            mnuModifica.Size = new Size(127, 38);
            mnuModifica.Text = "Modifica";
            mnuModifica.Click += mnuModifica_Click;
            // 
            // mnuCancella
            // 
            mnuCancella.Name = "mnuCancella";
            mnuCancella.Size = new Size(123, 38);
            mnuCancella.Text = "Cancella";
            mnuCancella.Click += mnuCancella_Click;
            // 
            // lstCategorie
            // 
            lstCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCategorie.FormattingEnabled = true;
            lstCategorie.IntegralHeight = false;
            lstCategorie.ItemHeight = 32;
            lstCategorie.Location = new Point(12, 59);
            lstCategorie.Name = "lstCategorie";
            lstCategorie.Size = new Size(500, 389);
            lstCategorie.TabIndex = 1;
            // 
            // FrmCategorie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 460);
            Controls.Add(lstCategorie);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmCategorie";
            Text = "Categorie";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAggiungi;
        private ToolStripMenuItem mnuModifica;
        private ToolStripMenuItem mnuCancella;
        private ListBox lstCategorie;
    }
}