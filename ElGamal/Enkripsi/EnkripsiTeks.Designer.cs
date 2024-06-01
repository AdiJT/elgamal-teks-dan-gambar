namespace ElGamal.Enkripsi
{
    partial class EnkripsiTeks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWaktu = new System.Windows.Forms.Label();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxAsli = new System.Windows.Forms.TextBox();
            this.textBoxHasilEnkripsi = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMSE = new System.Windows.Forms.Label();
            this.labelPSNR = new System.Windows.Forms.Label();
            this.labelPSNRA = new System.Windows.Forms.Label();
            this.labelMSEA = new System.Windows.Forms.Label();
            this.labelPSNRB = new System.Windows.Forms.Label();
            this.labelMSEB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 579);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 553);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(856, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWaktu);
            this.panel1.Controls.Add(this.buttonEnkripsi);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonBuka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 34);
            this.panel1.TabIndex = 1;
            // 
            // labelWaktu
            // 
            this.labelWaktu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWaktu.AutoSize = true;
            this.labelWaktu.Location = new System.Drawing.Point(623, 10);
            this.labelWaktu.Name = "labelWaktu";
            this.labelWaktu.Size = new System.Drawing.Size(68, 13);
            this.labelWaktu.TabIndex = 4;
            this.labelWaktu.Text = "Lama Proses";
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEnkripsi.Location = new System.Drawing.Point(777, 5);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(75, 23);
            this.buttonEnkripsi.TabIndex = 2;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(87, 5);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 23);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan Hasil";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBuka
            // 
            this.buttonBuka.Location = new System.Drawing.Point(6, 5);
            this.buttonBuka.Name = "buttonBuka";
            this.buttonBuka.Size = new System.Drawing.Size(75, 23);
            this.buttonBuka.TabIndex = 0;
            this.buttonBuka.Text = "Buka";
            this.buttonBuka.UseVisualStyleBackColor = true;
            this.buttonBuka.Click += new System.EventHandler(this.buttonBuka_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxAsli);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHasilEnkripsi);
            this.splitContainer1.Size = new System.Drawing.Size(856, 464);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBoxAsli
            // 
            this.textBoxAsli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAsli.Location = new System.Drawing.Point(0, 0);
            this.textBoxAsli.Multiline = true;
            this.textBoxAsli.Name = "textBoxAsli";
            this.textBoxAsli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAsli.Size = new System.Drawing.Size(425, 464);
            this.textBoxAsli.TabIndex = 0;
            // 
            // textBoxHasilEnkripsi
            // 
            this.textBoxHasilEnkripsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHasilEnkripsi.Location = new System.Drawing.Point(0, 0);
            this.textBoxHasilEnkripsi.Multiline = true;
            this.textBoxHasilEnkripsi.Name = "textBoxHasilEnkripsi";
            this.textBoxHasilEnkripsi.ReadOnly = true;
            this.textBoxHasilEnkripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHasilEnkripsi.Size = new System.Drawing.Size(427, 464);
            this.textBoxHasilEnkripsi.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Cipher Teks(*.cipher)|*.cipher";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelPSNRB);
            this.panel2.Controls.Add(this.labelMSEB);
            this.panel2.Controls.Add(this.labelPSNRA);
            this.panel2.Controls.Add(this.labelMSEA);
            this.panel2.Controls.Add(this.labelPSNR);
            this.panel2.Controls.Add(this.labelMSE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 34);
            this.panel2.TabIndex = 3;
            // 
            // labelMSE
            // 
            this.labelMSE.AutoSize = true;
            this.labelMSE.Location = new System.Drawing.Point(9, 10);
            this.labelMSE.Name = "labelMSE";
            this.labelMSE.Size = new System.Drawing.Size(45, 13);
            this.labelMSE.TabIndex = 0;
            this.labelMSE.Text = "MSE : 0";
            // 
            // labelPSNR
            // 
            this.labelPSNR.AutoSize = true;
            this.labelPSNR.Location = new System.Drawing.Point(117, 10);
            this.labelPSNR.Name = "labelPSNR";
            this.labelPSNR.Size = new System.Drawing.Size(52, 13);
            this.labelPSNR.TabIndex = 1;
            this.labelPSNR.Text = "PSNR : 0";
            // 
            // labelPSNRA
            // 
            this.labelPSNRA.AutoSize = true;
            this.labelPSNRA.Location = new System.Drawing.Point(357, 11);
            this.labelPSNRA.Name = "labelPSNRA";
            this.labelPSNRA.Size = new System.Drawing.Size(61, 13);
            this.labelPSNRA.TabIndex = 3;
            this.labelPSNRA.Text = "PSNR a : 0";
            // 
            // labelMSEA
            // 
            this.labelMSEA.AutoSize = true;
            this.labelMSEA.Location = new System.Drawing.Point(249, 11);
            this.labelMSEA.Name = "labelMSEA";
            this.labelMSEA.Size = new System.Drawing.Size(54, 13);
            this.labelMSEA.TabIndex = 2;
            this.labelMSEA.Text = "MSE a : 0";
            // 
            // labelPSNRB
            // 
            this.labelPSNRB.AutoSize = true;
            this.labelPSNRB.Location = new System.Drawing.Point(590, 10);
            this.labelPSNRB.Name = "labelPSNRB";
            this.labelPSNRB.Size = new System.Drawing.Size(61, 13);
            this.labelPSNRB.TabIndex = 5;
            this.labelPSNRB.Text = "PSNR b : 0";
            // 
            // labelMSEB
            // 
            this.labelMSEB.AutoSize = true;
            this.labelMSEB.Location = new System.Drawing.Point(482, 10);
            this.labelMSEB.Name = "labelMSEB";
            this.labelMSEB.Size = new System.Drawing.Size(54, 13);
            this.labelMSEB.TabIndex = 4;
            this.labelMSEB.Text = "MSE b : 0";
            // 
            // EnkripsiTeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EnkripsiTeks";
            this.Size = new System.Drawing.Size(862, 579);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxAsli;
        private System.Windows.Forms.TextBox textBoxHasilEnkripsi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelWaktu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMSE;
        private System.Windows.Forms.Label labelPSNR;
        private System.Windows.Forms.Label labelPSNRA;
        private System.Windows.Forms.Label labelMSEA;
        private System.Windows.Forms.Label labelPSNRB;
        private System.Windows.Forms.Label labelMSEB;
    }
}
