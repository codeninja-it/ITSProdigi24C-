namespace OttavaApp
{
    partial class FrmProdotto
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
            btnSalva = new Button();
            txtNome = new TextBox();
            numPrezzo = new NumericUpDown();
            lstCategorie = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescrizione = new TextBox();
            label4 = new Label();
            txtImmagine = new TextBox();
            label5 = new Label();
            btnImmagine = new Button();
            dlgImmagine = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numPrezzo).BeginInit();
            SuspendLayout();
            // 
            // btnAnnulla
            // 
            btnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnulla.Location = new Point(751, 647);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(150, 46);
            btnAnnulla.TabIndex = 0;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // btnSalva
            // 
            btnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalva.Location = new Point(595, 647);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(150, 46);
            btnSalva.TabIndex = 1;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(210, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(691, 39);
            txtNome.TabIndex = 2;
            // 
            // numPrezzo
            // 
            numPrezzo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numPrezzo.Location = new Point(210, 57);
            numPrezzo.Name = "numPrezzo";
            numPrezzo.Size = new Size(691, 39);
            numPrezzo.TabIndex = 3;
            // 
            // lstCategorie
            // 
            lstCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCategorie.FormattingEnabled = true;
            lstCategorie.IntegralHeight = false;
            lstCategorie.ItemHeight = 32;
            lstCategorie.Location = new Point(210, 309);
            lstCategorie.Name = "lstCategorie";
            lstCategorie.SelectionMode = SelectionMode.MultiSimple;
            lstCategorie.Size = new Size(691, 327);
            lstCategorie.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 6;
            label2.Text = "Prezzo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 309);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 7;
            label3.Text = "Categorie";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescrizione.Location = new Point(210, 102);
            txtDescrizione.Multiline = true;
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(691, 154);
            txtDescrizione.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 105);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 9;
            label4.Text = "Descrizione";
            // 
            // txtImmagine
            // 
            txtImmagine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImmagine.Location = new Point(210, 264);
            txtImmagine.Name = "txtImmagine";
            txtImmagine.Size = new Size(605, 39);
            txtImmagine.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 267);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 11;
            label5.Text = "Immagine";
            // 
            // btnImmagine
            // 
            btnImmagine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImmagine.Location = new Point(821, 264);
            btnImmagine.Name = "btnImmagine";
            btnImmagine.Size = new Size(80, 39);
            btnImmagine.TabIndex = 12;
            btnImmagine.Text = "...";
            btnImmagine.UseVisualStyleBackColor = true;
            btnImmagine.Click += btnImmagine_Click;
            // 
            // dlgImmagine
            // 
            dlgImmagine.DefaultExt = "jpg";
            dlgImmagine.FileName = "openFileDialog1";
            dlgImmagine.Filter = "Immagine JPG|*.jpg|Immagine GIF|*.gif|Tutti i files|*.*";
            dlgImmagine.Title = "Scegli immagine prodotto";
            // 
            // FrmProdotto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 705);
            Controls.Add(btnImmagine);
            Controls.Add(label5);
            Controls.Add(txtImmagine);
            Controls.Add(label4);
            Controls.Add(txtDescrizione);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstCategorie);
            Controls.Add(numPrezzo);
            Controls.Add(txtNome);
            Controls.Add(btnSalva);
            Controls.Add(btnAnnulla);
            Name = "FrmProdotto";
            Text = "FrmProdotto";
            Shown += FrmProdotto_Shown;
            ((System.ComponentModel.ISupportInitialize)numPrezzo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnnulla;
        private Button btnSalva;
        private TextBox txtNome;
        private NumericUpDown numPrezzo;
        private ListBox lstCategorie;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescrizione;
        private Label label4;
        private TextBox txtImmagine;
        private Label label5;
        private Button btnImmagine;
        private OpenFileDialog dlgImmagine;
    }
}