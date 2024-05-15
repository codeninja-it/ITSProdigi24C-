namespace OttavaApp
{
    partial class FrmImmagini
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
            mnuSostituisci = new ToolStripMenuItem();
            mnuCancella = new ToolStripMenuItem();
            dlgImmagini = new OpenFileDialog();
            lstImmagini = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAggiungi, mnuSostituisci, mnuCancella });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(728, 42);
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
            // mnuSostituisci
            // 
            mnuSostituisci.Name = "mnuSostituisci";
            mnuSostituisci.Size = new Size(140, 38);
            mnuSostituisci.Text = "Sostituisci";
            // 
            // mnuCancella
            // 
            mnuCancella.Name = "mnuCancella";
            mnuCancella.Size = new Size(123, 38);
            mnuCancella.Text = "Cancella";
            // 
            // dlgImmagini
            // 
            dlgImmagini.DefaultExt = "jpg";
            dlgImmagini.FileName = "dlgImmagini";
            dlgImmagini.Filter = "Immagine JPG|*.jpg|Immagine GIF|*.gif|Tutti i files|*.*";
            dlgImmagini.Title = "ApriImmagine";
            // 
            // lstImmagini
            // 
            lstImmagini.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstImmagini.FormattingEnabled = true;
            lstImmagini.IntegralHeight = false;
            lstImmagini.ItemHeight = 32;
            lstImmagini.Location = new Point(0, 43);
            lstImmagini.Name = "lstImmagini";
            lstImmagini.Size = new Size(728, 496);
            lstImmagini.TabIndex = 1;
            // 
            // FrmImmagini
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 538);
            Controls.Add(lstImmagini);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmImmagini";
            Text = "FrmImmagini";
            Shown += FrmImmagini_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAggiungi;
        private ToolStripMenuItem mnuSostituisci;
        private ToolStripMenuItem mnuCancella;
        private OpenFileDialog dlgImmagini;
        private ListBox lstImmagini;
    }
}