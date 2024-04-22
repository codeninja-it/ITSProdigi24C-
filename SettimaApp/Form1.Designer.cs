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
            chkCancella = new CheckBox();
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
            lstContatti.SelectedIndexChanged += lstContatti_SelectedIndexChanged;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAggiungi.Location = new Point(548, 12);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(135, 46);
            btnAggiungi.TabIndex = 1;
            btnAggiungi.Text = "add";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // chkCancella
            // 
            chkCancella.AutoSize = true;
            chkCancella.Location = new Point(12, 18);
            chkCancella.Name = "chkCancella";
            chkCancella.Size = new Size(131, 36);
            chkCancella.TabIndex = 2;
            chkCancella.Text = "cancella";
            chkCancella.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 530);
            Controls.Add(chkCancella);
            Controls.Add(btnAggiungi);
            Controls.Add(lstContatti);
            Name = "Form1";
            Text = "Rubrica";
            Activated += Form1_Activated;
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstContatti;
        private Button btnAggiungi;
        private CheckBox chkCancella;
    }
}
