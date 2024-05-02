namespace OttavaApp
{
    partial class Form1
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
            lstProdotti = new ListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuNuovo = new ToolStripMenuItem();
            mnuApri = new ToolStripMenuItem();
            mnuSalva = new ToolStripMenuItem();
            mnuEsci = new ToolStripMenuItem();
            prodottiToolStripMenuItem = new ToolStripMenuItem();
            mnuAggiungiProdotto = new ToolStripMenuItem();
            mnuModificaProdotto = new ToolStripMenuItem();
            mnuCancellaProdotto = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            dlgApri = new OpenFileDialog();
            dlgSalva = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstProdotti
            // 
            lstProdotti.FormattingEnabled = true;
            lstProdotti.ItemHeight = 32;
            lstProdotti.Location = new Point(12, 70);
            lstProdotti.Name = "lstProdotti";
            lstProdotti.SelectionMode = SelectionMode.MultiSimple;
            lstProdotti.Size = new Size(776, 356);
            lstProdotti.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, prodottiToolStripMenuItem, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNuovo, mnuApri, mnuSalva, mnuEsci });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // mnuNuovo
            // 
            mnuNuovo.Name = "mnuNuovo";
            mnuNuovo.Size = new Size(219, 44);
            mnuNuovo.Text = "Nuovo";
            mnuNuovo.Click += mnuNuovo_Click;
            // 
            // mnuApri
            // 
            mnuApri.Name = "mnuApri";
            mnuApri.Size = new Size(219, 44);
            mnuApri.Text = "Apri";
            mnuApri.Click += mnuApri_Click;
            // 
            // mnuSalva
            // 
            mnuSalva.Name = "mnuSalva";
            mnuSalva.Size = new Size(219, 44);
            mnuSalva.Text = "Salva";
            mnuSalva.Click += mnuSalva_Click;
            // 
            // mnuEsci
            // 
            mnuEsci.Name = "mnuEsci";
            mnuEsci.Size = new Size(219, 44);
            mnuEsci.Text = "Esci";
            mnuEsci.Click += mnuEsci_Click;
            // 
            // prodottiToolStripMenuItem
            // 
            prodottiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAggiungiProdotto, mnuModificaProdotto, mnuCancellaProdotto });
            prodottiToolStripMenuItem.Name = "prodottiToolStripMenuItem";
            prodottiToolStripMenuItem.Size = new Size(119, 36);
            prodottiToolStripMenuItem.Text = "Prodotti";
            // 
            // mnuAggiungiProdotto
            // 
            mnuAggiungiProdotto.Name = "mnuAggiungiProdotto";
            mnuAggiungiProdotto.Size = new Size(359, 44);
            mnuAggiungiProdotto.Text = "Aggiungi";
            mnuAggiungiProdotto.Click += mnuAggiungiProdotto_Click;
            // 
            // mnuModificaProdotto
            // 
            mnuModificaProdotto.Name = "mnuModificaProdotto";
            mnuModificaProdotto.Size = new Size(359, 44);
            mnuModificaProdotto.Text = "Modifica";
            mnuModificaProdotto.Click += mnuModificaProdotto_Click;
            // 
            // mnuCancellaProdotto
            // 
            mnuCancellaProdotto.Name = "mnuCancellaProdotto";
            mnuCancellaProdotto.Size = new Size(359, 44);
            mnuCancellaProdotto.Text = "Cancella";
            mnuCancellaProdotto.Click += mnuCancellaProdotto_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(45, 36);
            mnuHelp.Text = "?";
            // 
            // dlgApri
            // 
            dlgApri.FileName = "openFileDialog1";
            // 
            // dlgSalva
            // 
            dlgSalva.FileOk += dlgSalva_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstProdotti);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProdotti;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuNuovo;
        private ToolStripMenuItem mnuApri;
        private ToolStripMenuItem mnuSalva;
        private ToolStripMenuItem mnuEsci;
        private ToolStripMenuItem mnuHelp;
        private OpenFileDialog dlgApri;
        private SaveFileDialog dlgSalva;
        private ToolStripMenuItem prodottiToolStripMenuItem;
        private ToolStripMenuItem mnuAggiungiProdotto;
        private ToolStripMenuItem mnuModificaProdotto;
        private ToolStripMenuItem mnuCancellaProdotto;
    }
}
