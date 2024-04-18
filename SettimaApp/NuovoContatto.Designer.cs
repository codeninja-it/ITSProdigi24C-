namespace SettimaApp
{
    partial class NuovoContatto
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
            btnSalva = new Button();
            btnAnnulla = new Button();
            SuspendLayout();
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(306, 392);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(326, 46);
            btnSalva.TabIndex = 0;
            btnSalva.Text = "salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Location = new Point(638, 392);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(150, 46);
            btnAnnulla.TabIndex = 1;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // NuovoContatto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnnulla);
            Controls.Add(btnSalva);
            Name = "NuovoContatto";
            Text = "NuovoContatto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalva;
        private Button btnAnnulla;
    }
}