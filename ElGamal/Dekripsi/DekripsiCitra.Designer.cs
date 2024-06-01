namespace ElGamal.Dekripsi
{
    partial class DekripsiCitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DekripsiCitra));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDekripsi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customPictureBoxPlain = new OlahCitra.CustomControl.CustomPictureBox();
            this.customPictureBoxCipher = new OlahCitra.CustomControl.CustomPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelWaktu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 582);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 556);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(843, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWaktu);
            this.panel1.Controls.Add(this.buttonDekripsi);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonBuka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 34);
            this.panel1.TabIndex = 1;
            // 
            // buttonDekripsi
            // 
            this.buttonDekripsi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDekripsi.Location = new System.Drawing.Point(764, 5);
            this.buttonDekripsi.Name = "buttonDekripsi";
            this.buttonDekripsi.Size = new System.Drawing.Size(75, 23);
            this.buttonDekripsi.TabIndex = 2;
            this.buttonDekripsi.Text = "Dekripsi";
            this.buttonDekripsi.UseVisualStyleBackColor = true;
            this.buttonDekripsi.Click += new System.EventHandler(this.buttonDekripsi_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.customPictureBoxPlain, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.customPictureBoxCipher, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(843, 507);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // customPictureBoxPlain
            // 
            this.customPictureBoxPlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxPlain.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxPlain.Image")));
            this.customPictureBoxPlain.Location = new System.Drawing.Point(424, 3);
            this.customPictureBoxPlain.Name = "customPictureBoxPlain";
            this.customPictureBoxPlain.Size = new System.Drawing.Size(416, 501);
            this.customPictureBoxPlain.TabIndex = 3;
            this.customPictureBoxPlain.Title = "Gambar Hasil Dekripsi";
            // 
            // customPictureBoxCipher
            // 
            this.customPictureBoxCipher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxCipher.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxCipher.Image")));
            this.customPictureBoxCipher.Location = new System.Drawing.Point(3, 3);
            this.customPictureBoxCipher.Name = "customPictureBoxCipher";
            this.customPictureBoxCipher.Size = new System.Drawing.Size(415, 501);
            this.customPictureBoxCipher.TabIndex = 2;
            this.customPictureBoxCipher.Title = "Gambar Cipher";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Encrypt Files (*.encrypt)|*.encrypt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp";
            // 
            // labelWaktu
            // 
            this.labelWaktu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWaktu.AutoSize = true;
            this.labelWaktu.Location = new System.Drawing.Point(621, 10);
            this.labelWaktu.Name = "labelWaktu";
            this.labelWaktu.Size = new System.Drawing.Size(74, 13);
            this.labelWaktu.TabIndex = 3;
            this.labelWaktu.Text = "Lama Proses :";
            // 
            // DekripsiCitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DekripsiCitra";
            this.Size = new System.Drawing.Size(849, 582);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDekripsi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private OlahCitra.CustomControl.CustomPictureBox customPictureBoxPlain;
        private OlahCitra.CustomControl.CustomPictureBox customPictureBoxCipher;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelWaktu;
    }
}
