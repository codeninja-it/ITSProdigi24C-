namespace OttavaApp
{
    partial class FrmGestisciCategoria
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
            btnAnnulla = new Button();
            txtCategoria = new TextBox();
            btnSalva = new Button();
            label1 = new Label();
            txtDescrizione = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAnnulla
            // 
            btnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnulla.Location = new Point(395, 389);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(150, 46);
            btnAnnulla.TabIndex = 0;
            btnAnnulla.Text = "Anulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoria.Location = new Point(166, 12);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(379, 39);
            txtCategoria.TabIndex = 1;
            // 
            // btnSalva
            // 
            btnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalva.Location = new Point(239, 389);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(150, 46);
            btnSalva.TabIndex = 2;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 3;
            label1.Text = "Categoria";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(166, 57);
            txtDescrizione.Multiline = true;
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(379, 326);
            txtDescrizione.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 60);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 5;
            label2.Text = "Descrizione";
            // 
            // FrmGestisciCategoria
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 447);
            Controls.Add(label2);
            Controls.Add(txtDescrizione);
            Controls.Add(label1);
            Controls.Add(btnSalva);
            Controls.Add(txtCategoria);
            Controls.Add(btnAnnulla);
            Name = "FrmGestisciCategoria";
            Text = "FrmGestisciCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnnulla;
        private TextBox txtCategoria;
        private Button btnSalva;
        private Label label1;
        private TextBox txtDescrizione;
        private Label label2;
    }
}