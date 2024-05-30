namespace ElGamal.Enkripsi
{
    partial class EnkripsiCitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnkripsiCitra));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customPictureBoxHasil = new OlahCitra.CustomControl.CustomPictureBox();
            this.customPictureBoxAsli = new OlahCitra.CustomControl.CustomPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMSE = new System.Windows.Forms.Label();
            this.labelPSNR = new System.Windows.Forms.Label();
            this.labelCrossEntropyR = new System.Windows.Forms.Label();
            this.labelCrossEntropyGreen = new System.Windows.Forms.Label();
            this.labelCrossEntropyBlue = new System.Windows.Forms.Label();
            this.labelCrossEntropyGrayScale = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 561);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(859, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEnkripsi);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonBuka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 34);
            this.panel1.TabIndex = 1;
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEnkripsi.Location = new System.Drawing.Point(780, 5);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.customPictureBoxHasil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.customPictureBoxAsli, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 452);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // customPictureBoxHasil
            // 
            this.customPictureBoxHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxHasil.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxHasil.Image")));
            this.customPictureBoxHasil.Location = new System.Drawing.Point(432, 3);
            this.customPictureBoxHasil.Name = "customPictureBoxHasil";
            this.customPictureBoxHasil.Size = new System.Drawing.Size(424, 446);
            this.customPictureBoxHasil.TabIndex = 3;
            this.customPictureBoxHasil.Title = "Gambar Hasil Enkripsi";
            // 
            // customPictureBoxAsli
            // 
            this.customPictureBoxAsli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxAsli.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxAsli.Image")));
            this.customPictureBoxAsli.Location = new System.Drawing.Point(3, 3);
            this.customPictureBoxAsli.Name = "customPictureBoxAsli";
            this.customPictureBoxAsli.Size = new System.Drawing.Size(423, 446);
            this.customPictureBoxAsli.TabIndex = 2;
            this.customPictureBoxAsli.Title = "Gambar Asli";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpeg;*.jpg;*.bmp";
            this.openFileDialog1.Title = "Pilih Gambar Untuk Dienkripsi";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpeg";
            this.saveFileDialog1.Filter = "Encrypt Files (*.encrypt)|*.encrypt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCrossEntropyGrayScale);
            this.panel2.Controls.Add(this.labelCrossEntropyBlue);
            this.panel2.Controls.Add(this.labelCrossEntropyGreen);
            this.panel2.Controls.Add(this.labelCrossEntropyR);
            this.panel2.Controls.Add(this.labelPSNR);
            this.panel2.Controls.Add(this.labelMSE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 54);
            this.panel2.TabIndex = 3;
            // 
            // labelMSE
            // 
            this.labelMSE.AutoSize = true;
            this.labelMSE.Location = new System.Drawing.Point(6, 6);
            this.labelMSE.Name = "labelMSE";
            this.labelMSE.Size = new System.Drawing.Size(45, 13);
            this.labelMSE.TabIndex = 0;
            this.labelMSE.Text = "MSE : 0";
            // 
            // labelPSNR
            // 
            this.labelPSNR.AutoSize = true;
            this.labelPSNR.Location = new System.Drawing.Point(126, 6);
            this.labelPSNR.Name = "labelPSNR";
            this.labelPSNR.Size = new System.Drawing.Size(52, 13);
            this.labelPSNR.TabIndex = 1;
            this.labelPSNR.Text = "PSNR : 0";
            // 
            // labelCrossEntropyR
            // 
            this.labelCrossEntropyR.AutoSize = true;
            this.labelCrossEntropyR.Location = new System.Drawing.Point(236, 6);
            this.labelCrossEntropyR.Name = "labelCrossEntropyR";
            this.labelCrossEntropyR.Size = new System.Drawing.Size(163, 13);
            this.labelCrossEntropyR.TabIndex = 2;
            this.labelCrossEntropyR.Text = "Cross Entropy Histogram Red :  0";
            // 
            // labelCrossEntropyGreen
            // 
            this.labelCrossEntropyGreen.AutoSize = true;
            this.labelCrossEntropyGreen.Location = new System.Drawing.Point(427, 6);
            this.labelCrossEntropyGreen.Name = "labelCrossEntropyGreen";
            this.labelCrossEntropyGreen.Size = new System.Drawing.Size(172, 13);
            this.labelCrossEntropyGreen.TabIndex = 3;
            this.labelCrossEntropyGreen.Text = "Cross Entropy Histogram Green :  0";
            // 
            // labelCrossEntropyBlue
            // 
            this.labelCrossEntropyBlue.AutoSize = true;
            this.labelCrossEntropyBlue.Location = new System.Drawing.Point(625, 6);
            this.labelCrossEntropyBlue.Name = "labelCrossEntropyBlue";
            this.labelCrossEntropyBlue.Size = new System.Drawing.Size(164, 13);
            this.labelCrossEntropyBlue.TabIndex = 4;
            this.labelCrossEntropyBlue.Text = "Cross Entropy Histogram Blue :  0";
            // 
            // labelCrossEntropyGrayScale
            // 
            this.labelCrossEntropyGrayScale.AutoSize = true;
            this.labelCrossEntropyGrayScale.Location = new System.Drawing.Point(6, 29);
            this.labelCrossEntropyGrayScale.Name = "labelCrossEntropyGrayScale";
            this.labelCrossEntropyGrayScale.Size = new System.Drawing.Size(189, 13);
            this.labelCrossEntropyGrayScale.TabIndex = 5;
            this.labelCrossEntropyGrayScale.Text = "Cross Entropy Histogram GrayScale:  0";
            // 
            // EnkripsiCitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EnkripsiCitra";
            this.Size = new System.Drawing.Size(865, 587);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonEnkripsi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private OlahCitra.CustomControl.CustomPictureBox customPictureBoxHasil;
        private OlahCitra.CustomControl.CustomPictureBox customPictureBoxAsli;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMSE;
        private System.Windows.Forms.Label labelPSNR;
        private System.Windows.Forms.Label labelCrossEntropyR;
        private System.Windows.Forms.Label labelCrossEntropyGreen;
        private System.Windows.Forms.Label labelCrossEntropyBlue;
        private System.Windows.Forms.Label labelCrossEntropyGrayScale;
    }
}
