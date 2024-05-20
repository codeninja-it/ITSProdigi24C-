namespace OttavaApp
{
    partial class FrmServer
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
            txtBuffer = new TextBox();
            menuStrip1 = new MenuStrip();
            mnuAvvia = new ToolStripMenuItem();
            mnuFerma = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuffer
            // 
            txtBuffer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuffer.Location = new Point(12, 109);
            txtBuffer.Multiline = true;
            txtBuffer.Name = "txtBuffer";
            txtBuffer.Size = new Size(797, 546);
            txtBuffer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAvvia, mnuFerma });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuAvvia
            // 
            mnuAvvia.Name = "mnuAvvia";
            mnuAvvia.Size = new Size(91, 38);
            mnuAvvia.Text = "Avvia";
            mnuAvvia.Click += mnuAvvia_Click;
            // 
            // mnuFerma
            // 
            mnuFerma.Name = "mnuFerma";
            mnuFerma.Size = new Size(100, 38);
            mnuFerma.Text = "Ferma";
            mnuFerma.Click += mnuFerma_Click;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 667);
            Controls.Add(txtBuffer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmServer";
            Text = "FrmServer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuffer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuAvvia;
        private ToolStripMenuItem mnuFerma;
    }
}