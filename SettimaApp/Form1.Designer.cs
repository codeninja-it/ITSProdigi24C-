namespace SettimaApp
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
            lstContatti = new ListBox();
            btnAggiungi = new Button();
            SuspendLayout();
            // 
            // lstContatti
            // 
            lstContatti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstContatti.FormattingEnabled = true;
            lstContatti.IntegralHeight = false;
            lstContatti.ItemHeight = 32;
            lstContatti.Location = new Point(12, 64);
            lstContatti.Name = "lstContatti";
            lstContatti.Size = new Size(671, 454);
            lstContatti.TabIndex = 0;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAggiungi.Location = new Point(586, 12);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(97, 46);
            btnAggiungi.TabIndex = 1;
            btnAggiungi.Text = "add";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 530);
            Controls.Add(btnAggiungi);
            Controls.Add(lstContatti);
            Name = "Form1";
            Text = "Rubrica";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstContatti;
        private Button btnAggiungi;
    }
}
