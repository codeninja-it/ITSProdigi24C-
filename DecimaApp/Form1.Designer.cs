namespace DecimaApp
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
            txtPunti = new TextBox();
            trkBuffer = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trkBuffer).BeginInit();
            SuspendLayout();
            // 
            // txtPunti
            // 
            txtPunti.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPunti.Location = new Point(12, 12);
            txtPunti.Name = "txtPunti";
            txtPunti.Size = new Size(1618, 39);
            txtPunti.TabIndex = 0;
            // 
            // trkBuffer
            // 
            trkBuffer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trkBuffer.Location = new Point(12, 57);
            trkBuffer.Maximum = 100;
            trkBuffer.Minimum = 1;
            trkBuffer.Name = "trkBuffer";
            trkBuffer.Size = new Size(1618, 90);
            trkBuffer.TabIndex = 1;
            trkBuffer.Value = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 1230);
            Controls.Add(trkBuffer);
            Controls.Add(txtPunti);
            Name = "Form1";
            Text = "Form1";
            ResizeEnd += Form1_ResizeEnd;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)trkBuffer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPunti;
        private TrackBar trkBuffer;
    }
}
