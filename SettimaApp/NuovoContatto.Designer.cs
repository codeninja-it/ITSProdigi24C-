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
            txtNome = new TextBox();
            txtCognome = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSalva
            // 
            btnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalva.Location = new Point(468, 206);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(326, 46);
            btnSalva.TabIndex = 0;
            btnSalva.Text = "salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnulla.Location = new Point(800, 206);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(150, 46);
            btnAnnulla.TabIndex = 1;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(161, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(789, 39);
            txtNome.TabIndex = 2;
            // 
            // txtCognome
            // 
            txtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCognome.Location = new Point(161, 57);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(789, 39);
            txtCognome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(161, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(789, 39);
            txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Location = new Point(161, 147);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(789, 39);
            txtTelefono.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 6;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 7;
            label2.Text = "cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 8;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 9;
            label4.Text = "telefono";
            // 
            // NuovoContatto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 264);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(btnAnnulla);
            Controls.Add(btnSalva);
            Name = "NuovoContatto";
            Text = "NuovoContatto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalva;
        private Button btnAnnulla;
        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}