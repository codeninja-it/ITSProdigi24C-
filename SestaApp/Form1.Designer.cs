namespace SestaApp
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
            numPeso = new NumericUpDown();
            numAltezza = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnCalcola = new Button();
            txtRisultato = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltezza).BeginInit();
            SuspendLayout();
            // 
            // numPeso
            // 
            numPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numPeso.Location = new Point(108, 12);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(724, 39);
            numPeso.TabIndex = 0;
            // 
            // numAltezza
            // 
            numAltezza.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numAltezza.Location = new Point(108, 57);
            numAltezza.Name = "numAltezza";
            numAltezza.Size = new Size(724, 39);
            numAltezza.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 2;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 3;
            label2.Text = "Altezza";
            // 
            // btnCalcola
            // 
            btnCalcola.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalcola.Location = new Point(12, 102);
            btnCalcola.Name = "btnCalcola";
            btnCalcola.Size = new Size(820, 419);
            btnCalcola.TabIndex = 4;
            btnCalcola.Text = "calcola";
            btnCalcola.UseVisualStyleBackColor = true;
            btnCalcola.Click += btnCalcola_Click;
            // 
            // txtRisultato
            // 
            txtRisultato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRisultato.Location = new Point(12, 527);
            txtRisultato.Name = "txtRisultato";
            txtRisultato.Size = new Size(820, 39);
            txtRisultato.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 578);
            Controls.Add(txtRisultato);
            Controls.Add(btnCalcola);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numAltezza);
            Controls.Add(numPeso);
            Name = "Form1";
            Text = "BMI";
            Load += Caricamento;
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltezza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numPeso;
        private NumericUpDown numAltezza;
        private Label label1;
        private Label label2;
        private Button btnCalcola;
        private TextBox txtRisultato;
    }
}
