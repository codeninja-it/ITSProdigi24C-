namespace NonaApp
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
            txtRisultato = new TextBox();
            btnApri = new Button();
            btnCalcola = new Button();
            dlgImmagine = new OpenFileDialog();
            trkHueStart = new TrackBar();
            lblHueStart = new Label();
            lblHueStop = new Label();
            trkHueStop = new TrackBar();
            pctAnteprima = new PictureBox();
            lstPoligoni = new ListBox();
            ((System.ComponentModel.ISupportInitialize)trkHueStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkHueStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctAnteprima).BeginInit();
            SuspendLayout();
            // 
            // txtRisultato
            // 
            txtRisultato.Location = new Point(12, 64);
            txtRisultato.Multiline = true;
            txtRisultato.Name = "txtRisultato";
            txtRisultato.Size = new Size(505, 161);
            txtRisultato.TabIndex = 0;
            // 
            // btnApri
            // 
            btnApri.Location = new Point(12, 12);
            btnApri.Name = "btnApri";
            btnApri.Size = new Size(505, 46);
            btnApri.TabIndex = 1;
            btnApri.Text = "...";
            btnApri.UseVisualStyleBackColor = true;
            btnApri.Click += btnApri_Click;
            // 
            // btnCalcola
            // 
            btnCalcola.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCalcola.Location = new Point(12, 910);
            btnCalcola.Name = "btnCalcola";
            btnCalcola.Size = new Size(505, 46);
            btnCalcola.TabIndex = 2;
            btnCalcola.Text = "calcola";
            btnCalcola.UseVisualStyleBackColor = true;
            btnCalcola.Click += btnCalcola_Click;
            // 
            // dlgImmagine
            // 
            dlgImmagine.FileName = "openFileDialog1";
            dlgImmagine.Filter = "File PNG|*.png|Tutti i file|*.*";
            // 
            // trkHueStart
            // 
            trkHueStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trkHueStart.Location = new Point(163, 710);
            trkHueStart.Maximum = 360;
            trkHueStart.Name = "trkHueStart";
            trkHueStart.Size = new Size(354, 90);
            trkHueStart.SmallChange = 5;
            trkHueStart.TabIndex = 3;
            trkHueStart.Value = 200;
            trkHueStart.Scroll += trkHueStart_Scroll;
            // 
            // lblHueStart
            // 
            lblHueStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHueStart.AutoSize = true;
            lblHueStart.Location = new Point(12, 710);
            lblHueStart.Name = "lblHueStart";
            lblHueStart.Size = new Size(43, 32);
            lblHueStart.TabIndex = 4;
            lblHueStart.Text = "Da";
            // 
            // lblHueStop
            // 
            lblHueStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHueStop.AutoSize = true;
            lblHueStop.Location = new Point(12, 806);
            lblHueStop.Name = "lblHueStop";
            lblHueStop.Size = new Size(29, 32);
            lblHueStop.TabIndex = 6;
            lblHueStop.Text = "A";
            // 
            // trkHueStop
            // 
            trkHueStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trkHueStop.Location = new Point(163, 806);
            trkHueStop.Maximum = 360;
            trkHueStop.Name = "trkHueStop";
            trkHueStop.Size = new Size(354, 90);
            trkHueStop.SmallChange = 5;
            trkHueStop.TabIndex = 5;
            trkHueStop.Value = 256;
            trkHueStop.Scroll += trkHueStop_Scroll;
            // 
            // pctAnteprima
            // 
            pctAnteprima.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pctAnteprima.Location = new Point(523, 12);
            pctAnteprima.Name = "pctAnteprima";
            pctAnteprima.Size = new Size(645, 944);
            pctAnteprima.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAnteprima.TabIndex = 7;
            pctAnteprima.TabStop = false;
            // 
            // lstPoligoni
            // 
            lstPoligoni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstPoligoni.FormattingEnabled = true;
            lstPoligoni.IntegralHeight = false;
            lstPoligoni.ItemHeight = 32;
            lstPoligoni.Location = new Point(12, 231);
            lstPoligoni.Name = "lstPoligoni";
            lstPoligoni.SelectionMode = SelectionMode.MultiSimple;
            lstPoligoni.Size = new Size(505, 461);
            lstPoligoni.TabIndex = 8;
            lstPoligoni.SelectedIndexChanged += lstPoligoni_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 968);
            Controls.Add(lstPoligoni);
            Controls.Add(pctAnteprima);
            Controls.Add(lblHueStop);
            Controls.Add(trkHueStop);
            Controls.Add(lblHueStart);
            Controls.Add(trkHueStart);
            Controls.Add(btnCalcola);
            Controls.Add(btnApri);
            Controls.Add(txtRisultato);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trkHueStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkHueStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctAnteprima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRisultato;
        private Button btnApri;
        private Button btnCalcola;
        private OpenFileDialog dlgImmagine;
        private TrackBar trkHueStart;
        private Label lblHueStart;
        private Label lblHueStop;
        private TrackBar trkHueStop;
        private PictureBox pctAnteprima;
        private ListBox lstPoligoni;
    }
}
