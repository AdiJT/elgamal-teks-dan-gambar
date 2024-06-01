namespace ElGamal.Dekripsi
{
    partial class DekripsiTeks
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
            this.buttonDeskripsi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.textBoxHasilDekripsi = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 703);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(4, 671);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1127, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWaktu);
            this.panel1.Controls.Add(this.buttonDeskripsi);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonBuka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 41);
            this.panel1.TabIndex = 1;
            // 
            // labelWaktu
            // 
            this.labelWaktu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWaktu.AutoSize = true;
            this.labelWaktu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelWaktu.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaktu.Location = new System.Drawing.Point(680, 8);
            this.labelWaktu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWaktu.Name = "labelWaktu";
            this.labelWaktu.Size = new System.Drawing.Size(108, 23);
            this.labelWaktu.TabIndex = 4;
            this.labelWaktu.Text = "Lama Proses";
            // 
            // buttonDeskripsi
            // 
            this.buttonDeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDeskripsi.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeskripsi.Location = new System.Drawing.Point(1021, 5);
            this.buttonDeskripsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeskripsi.Name = "buttonDeskripsi";
            this.buttonDeskripsi.Size = new System.Drawing.Size(100, 28);
            this.buttonDeskripsi.TabIndex = 2;
            this.buttonDeskripsi.Text = "Deskripsi";
            this.buttonDeskripsi.UseVisualStyleBackColor = true;
            this.buttonDeskripsi.Click += new System.EventHandler(this.buttonDeskripsi_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 53);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCipher);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxHasilDekripsi);
            this.splitContainer1.Size = new System.Drawing.Size(1127, 610);
            this.splitContainer1.SplitterDistance = 558;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCipher.Location = new System.Drawing.Point(0, 0);
            this.textBoxCipher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.ReadOnly = true;
            this.textBoxCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCipher.Size = new System.Drawing.Size(558, 610);
            this.textBoxCipher.TabIndex = 0;
            // 
            // textBoxHasilDekripsi
            // 
            this.textBoxHasilDekripsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHasilDekripsi.Location = new System.Drawing.Point(0, 0);
            this.textBoxHasilDekripsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHasilDekripsi.Multiline = true;
            this.textBoxHasilDekripsi.Name = "textBoxHasilDekripsi";
            this.textBoxHasilDekripsi.ReadOnly = true;
            this.textBoxHasilDekripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHasilDekripsi.Size = new System.Drawing.Size(564, 610);
            this.textBoxHasilDekripsi.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Cipher Teks(*.cipher)|*.cipher";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // DekripsiTeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DekripsiTeks";
            this.Size = new System.Drawing.Size(1135, 703);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDeskripsi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.TextBox textBoxHasilDekripsi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelWaktu;
    }
}
