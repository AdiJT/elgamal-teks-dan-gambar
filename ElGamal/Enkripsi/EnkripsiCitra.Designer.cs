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
            this.labelWaktu = new System.Windows.Forms.Label();
            this.buttonEnkripsi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customPictureBoxHasil = new OlahCitra.CustomControl.CustomPictureBox();
            this.customPictureBoxAsli = new OlahCitra.CustomControl.CustomPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPSNRB = new System.Windows.Forms.Label();
            this.labelMSEB = new System.Windows.Forms.Label();
            this.labelPSNRA = new System.Windows.Forms.Label();
            this.labelMSEA = new System.Windows.Forms.Label();
            this.labelCrossEntropyGrayScale = new System.Windows.Forms.Label();
            this.labelCrossEntropyBlue = new System.Windows.Forms.Label();
            this.labelCrossEntropyGreen = new System.Windows.Forms.Label();
            this.labelCrossEntropyR = new System.Windows.Forms.Label();
            this.labelPSNR = new System.Windows.Forms.Label();
            this.labelMSE = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(4, 868);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1592, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWaktu);
            this.panel1.Controls.Add(this.buttonEnkripsi);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonBuka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 41);
            this.panel1.TabIndex = 1;
            // 
            // labelWaktu
            // 
            this.labelWaktu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWaktu.AutoSize = true;
            this.labelWaktu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelWaktu.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaktu.Location = new System.Drawing.Point(1077, 8);
            this.labelWaktu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWaktu.Name = "labelWaktu";
            this.labelWaktu.Size = new System.Drawing.Size(114, 23);
            this.labelWaktu.TabIndex = 3;
            this.labelWaktu.Text = "Lama Proses:";
            // 
            // buttonEnkripsi
            // 
            this.buttonEnkripsi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEnkripsi.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnkripsi.Location = new System.Drawing.Point(1487, 5);
            this.buttonEnkripsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnkripsi.Name = "buttonEnkripsi";
            this.buttonEnkripsi.Size = new System.Drawing.Size(100, 28);
            this.buttonEnkripsi.TabIndex = 2;
            this.buttonEnkripsi.Text = "Enkripsi";
            this.buttonEnkripsi.UseVisualStyleBackColor = true;
            this.buttonEnkripsi.Click += new System.EventHandler(this.buttonEnkripsi_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(116, 6);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(133, 28);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan Hasil";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBuka
            // 
            this.buttonBuka.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuka.Location = new System.Drawing.Point(8, 6);
            this.buttonBuka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuka.Name = "buttonBuka";
            this.buttonBuka.Size = new System.Drawing.Size(100, 28);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.customPictureBoxHasil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.customPictureBoxAsli, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 53);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1592, 733);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // customPictureBoxHasil
            // 
            this.customPictureBoxHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxHasil.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxHasil.Image")));
            this.customPictureBoxHasil.Location = new System.Drawing.Point(801, 5);
            this.customPictureBoxHasil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customPictureBoxHasil.Name = "customPictureBoxHasil";
            this.customPictureBoxHasil.Size = new System.Drawing.Size(786, 723);
            this.customPictureBoxHasil.TabIndex = 3;
            this.customPictureBoxHasil.Title = "Gambar Hasil Enkripsi";
            // 
            // customPictureBoxAsli
            // 
            this.customPictureBoxAsli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxAsli.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxAsli.Image")));
            this.customPictureBoxAsli.Location = new System.Drawing.Point(5, 5);
            this.customPictureBoxAsli.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customPictureBoxAsli.Name = "customPictureBoxAsli";
            this.customPictureBoxAsli.Size = new System.Drawing.Size(786, 723);
            this.customPictureBoxAsli.TabIndex = 2;
            this.customPictureBoxAsli.Title = "Gambar Asli";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelPSNRB);
            this.panel2.Controls.Add(this.labelMSEB);
            this.panel2.Controls.Add(this.labelPSNRA);
            this.panel2.Controls.Add(this.labelMSEA);
            this.panel2.Controls.Add(this.labelCrossEntropyGrayScale);
            this.panel2.Controls.Add(this.labelCrossEntropyBlue);
            this.panel2.Controls.Add(this.labelCrossEntropyGreen);
            this.panel2.Controls.Add(this.labelCrossEntropyR);
            this.panel2.Controls.Add(this.labelPSNR);
            this.panel2.Controls.Add(this.labelMSE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 794);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1592, 66);
            this.panel2.TabIndex = 3;
            // 
            // labelPSNRB
            // 
            this.labelPSNRB.AutoSize = true;
            this.labelPSNRB.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPSNRB.Location = new System.Drawing.Point(495, 37);
            this.labelPSNRB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPSNRB.Name = "labelPSNRB";
            this.labelPSNRB.Size = new System.Drawing.Size(73, 18);
            this.labelPSNRB.TabIndex = 9;
            this.labelPSNRB.Text = "PSNR B : 0";
            // 
            // labelMSEB
            // 
            this.labelMSEB.AutoSize = true;
            this.labelMSEB.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSEB.Location = new System.Drawing.Point(495, 7);
            this.labelMSEB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMSEB.Name = "labelMSEB";
            this.labelMSEB.Size = new System.Drawing.Size(65, 18);
            this.labelMSEB.TabIndex = 8;
            this.labelMSEB.Text = "MSE B : 0";
            // 
            // labelPSNRA
            // 
            this.labelPSNRA.AutoSize = true;
            this.labelPSNRA.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPSNRA.Location = new System.Drawing.Point(227, 37);
            this.labelPSNRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPSNRA.Name = "labelPSNRA";
            this.labelPSNRA.Size = new System.Drawing.Size(71, 18);
            this.labelPSNRA.TabIndex = 7;
            this.labelPSNRA.Text = "PSNR A : 0";
            // 
            // labelMSEA
            // 
            this.labelMSEA.AutoSize = true;
            this.labelMSEA.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSEA.Location = new System.Drawing.Point(227, 7);
            this.labelMSEA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMSEA.Name = "labelMSEA";
            this.labelMSEA.Size = new System.Drawing.Size(63, 18);
            this.labelMSEA.TabIndex = 6;
            this.labelMSEA.Text = "MSE A : 0";
            // 
            // labelCrossEntropyGrayScale
            // 
            this.labelCrossEntropyGrayScale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCrossEntropyGrayScale.AutoSize = true;
            this.labelCrossEntropyGrayScale.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrossEntropyGrayScale.Location = new System.Drawing.Point(798, 9);
            this.labelCrossEntropyGrayScale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrossEntropyGrayScale.Name = "labelCrossEntropyGrayScale";
            this.labelCrossEntropyGrayScale.Size = new System.Drawing.Size(245, 18);
            this.labelCrossEntropyGrayScale.TabIndex = 5;
            this.labelCrossEntropyGrayScale.Text = "Cross Entropy Histogram GrayScale:  0";
            // 
            // labelCrossEntropyBlue
            // 
            this.labelCrossEntropyBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCrossEntropyBlue.AutoSize = true;
            this.labelCrossEntropyBlue.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrossEntropyBlue.Location = new System.Drawing.Point(1160, 38);
            this.labelCrossEntropyBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrossEntropyBlue.Name = "labelCrossEntropyBlue";
            this.labelCrossEntropyBlue.Size = new System.Drawing.Size(215, 18);
            this.labelCrossEntropyBlue.TabIndex = 4;
            this.labelCrossEntropyBlue.Text = "Cross Entropy Histogram Blue :  0";
            // 
            // labelCrossEntropyGreen
            // 
            this.labelCrossEntropyGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCrossEntropyGreen.AutoSize = true;
            this.labelCrossEntropyGreen.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrossEntropyGreen.Location = new System.Drawing.Point(1160, 9);
            this.labelCrossEntropyGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrossEntropyGreen.Name = "labelCrossEntropyGreen";
            this.labelCrossEntropyGreen.Size = new System.Drawing.Size(225, 18);
            this.labelCrossEntropyGreen.TabIndex = 3;
            this.labelCrossEntropyGreen.Text = "Cross Entropy Histogram Green :  0";
            // 
            // labelCrossEntropyR
            // 
            this.labelCrossEntropyR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCrossEntropyR.AutoSize = true;
            this.labelCrossEntropyR.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrossEntropyR.Location = new System.Drawing.Point(798, 39);
            this.labelCrossEntropyR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrossEntropyR.Name = "labelCrossEntropyR";
            this.labelCrossEntropyR.Size = new System.Drawing.Size(211, 18);
            this.labelCrossEntropyR.TabIndex = 2;
            this.labelCrossEntropyR.Text = "Cross Entropy Histogram Red :  0";
            // 
            // labelPSNR
            // 
            this.labelPSNR.AutoSize = true;
            this.labelPSNR.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPSNR.Location = new System.Drawing.Point(8, 36);
            this.labelPSNR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPSNR.Name = "labelPSNR";
            this.labelPSNR.Size = new System.Drawing.Size(61, 18);
            this.labelPSNR.TabIndex = 1;
            this.labelPSNR.Text = "PSNR : 0";
            // 
            // labelMSE
            // 
            this.labelMSE.AutoSize = true;
            this.labelMSE.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSE.Location = new System.Drawing.Point(8, 7);
            this.labelMSE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMSE.Name = "labelMSE";
            this.labelMSE.Size = new System.Drawing.Size(53, 18);
            this.labelMSE.TabIndex = 0;
            this.labelMSE.Text = "MSE : 0";
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
            // EnkripsiCitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EnkripsiCitra";
            this.Size = new System.Drawing.Size(1600, 900);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label labelPSNRB;
        private System.Windows.Forms.Label labelMSEB;
        private System.Windows.Forms.Label labelPSNRA;
        private System.Windows.Forms.Label labelMSEA;
        private System.Windows.Forms.Label labelWaktu;
    }
}
