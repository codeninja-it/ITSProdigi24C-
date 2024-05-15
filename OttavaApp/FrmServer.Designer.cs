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
            SuspendLayout();
            // 
            // txtBuffer
            // 
            txtBuffer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuffer.Location = new Point(12, 12);
            txtBuffer.Multiline = true;
            txtBuffer.Name = "txtBuffer";
            txtBuffer.Size = new Size(797, 643);
            txtBuffer.TabIndex = 0;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 667);
            Controls.Add(txtBuffer);
            Name = "FrmServer";
            Text = "FrmServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuffer;
    }
}