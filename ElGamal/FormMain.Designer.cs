namespace ElGamal
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCitra = new System.Windows.Forms.ComboBox();
            this.panelCitra = new System.Windows.Forms.Panel();
            this.elGamalKeyPanelCitra = new ElGamal.ElGamalKeyPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxTeks = new System.Windows.Forms.ComboBox();
            this.panelTeks = new System.Windows.Forms.Panel();
            this.elGamalKeyPanelTeks = new ElGamal.ElGamalKeyPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPSNR = new System.Windows.Forms.Label();
            this.labelMSE = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBuka = new System.Windows.Forms.Button();
            this.buttonUji = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelUji = new System.Windows.Forms.TableLayoutPanel();
            this.customPictureBoxHasil = new OlahCitra.CustomControl.CustomPictureBox();
            this.customPictureBoxAsli = new OlahCitra.CustomControl.CustomPictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanelUji.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Citra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelCitra, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.elGamalKeyPanelCitra, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxCitra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 34);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxCitra
            // 
            this.comboBoxCitra.FormattingEnabled = true;
            this.comboBoxCitra.Items.AddRange(new object[] {
            "Enkripsi",
            "Dekripsi"});
            this.comboBoxCitra.Location = new System.Drawing.Point(4, 6);
            this.comboBoxCitra.Name = "comboBoxCitra";
            this.comboBoxCitra.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCitra.TabIndex = 0;
            this.comboBoxCitra.SelectedIndexChanged += new System.EventHandler(this.comboBoxCitra_SelectedIndexChanged);
            // 
            // panelCitra
            // 
            this.panelCitra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCitra.Location = new System.Drawing.Point(3, 143);
            this.panelCitra.Name = "panelCitra";
            this.panelCitra.Size = new System.Drawing.Size(826, 369);
            this.panelCitra.TabIndex = 1;
            // 
            // elGamalKeyPanelCitra
            // 
            this.elGamalKeyPanelCitra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elGamalKeyPanelCitra.ElGamalKey = null;
            this.elGamalKeyPanelCitra.IsValid = false;
            this.elGamalKeyPanelCitra.JumlahDigitKunci = 27;
            this.elGamalKeyPanelCitra.Location = new System.Drawing.Point(3, 3);
            this.elGamalKeyPanelCitra.MinimalKunci = "255255255255255255255255255";
            this.elGamalKeyPanelCitra.Name = "elGamalKeyPanelCitra";
            this.elGamalKeyPanelCitra.Size = new System.Drawing.Size(826, 94);
            this.elGamalKeyPanelCitra.TabIndex = 2;
            this.elGamalKeyPanelCitra.OnKeyChanged += new System.EventHandler(this.elGamalKeyPanelCitra_OnKeyChanged);
            this.elGamalKeyPanelCitra.IsValidChanged += new System.EventHandler(this.elGamalKeyPanelCitra_IsValidChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelTeks, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.elGamalKeyPanelTeks, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 515);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxTeks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 34);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxTeks
            // 
            this.comboBoxTeks.FormattingEnabled = true;
            this.comboBoxTeks.Items.AddRange(new object[] {
            "Enkripsi",
            "Dekripsi"});
            this.comboBoxTeks.Location = new System.Drawing.Point(4, 6);
            this.comboBoxTeks.Name = "comboBoxTeks";
            this.comboBoxTeks.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeks.TabIndex = 0;
            this.comboBoxTeks.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeks_SelectedIndexChanged);
            // 
            // panelTeks
            // 
            this.panelTeks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeks.Location = new System.Drawing.Point(3, 143);
            this.panelTeks.Name = "panelTeks";
            this.panelTeks.Size = new System.Drawing.Size(826, 369);
            this.panelTeks.TabIndex = 1;
            // 
            // elGamalKeyPanelTeks
            // 
            this.elGamalKeyPanelTeks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elGamalKeyPanelTeks.ElGamalKey = null;
            this.elGamalKeyPanelTeks.IsValid = false;
            this.elGamalKeyPanelTeks.JumlahDigitKunci = 9;
            this.elGamalKeyPanelTeks.Location = new System.Drawing.Point(3, 3);
            this.elGamalKeyPanelTeks.MinimalKunci = "255255255";
            this.elGamalKeyPanelTeks.Name = "elGamalKeyPanelTeks";
            this.elGamalKeyPanelTeks.Size = new System.Drawing.Size(826, 94);
            this.elGamalKeyPanelTeks.TabIndex = 2;
            this.elGamalKeyPanelTeks.OnKeyChanged += new System.EventHandler(this.elGamalKeyPanelTeks_OnKeyChanged);
            this.elGamalKeyPanelTeks.IsValidChanged += new System.EventHandler(this.elGamalKeyPanelTeks_IsValidChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanelUji);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pengujian Citra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpeg;*.jpg;*.bmp";
            this.openFileDialog1.Title = "Pilih Gambar Untuk Dienkripsi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelPSNR);
            this.panel3.Controls.Add(this.labelMSE);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 54);
            this.panel3.TabIndex = 3;
            // 
            // labelPSNR
            // 
            this.labelPSNR.AutoSize = true;
            this.labelPSNR.Location = new System.Drawing.Point(108, 6);
            this.labelPSNR.Name = "labelPSNR";
            this.labelPSNR.Size = new System.Drawing.Size(52, 13);
            this.labelPSNR.TabIndex = 1;
            this.labelPSNR.Text = "PSNR : 0";
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.customPictureBoxHasil, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.customPictureBoxAsli, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(826, 380);
            this.tableLayoutPanel3.TabIndex = 2;
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
            // buttonUji
            // 
            this.buttonUji.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUji.Location = new System.Drawing.Point(747, 5);
            this.buttonUji.Name = "buttonUji";
            this.buttonUji.Size = new System.Drawing.Size(75, 23);
            this.buttonUji.TabIndex = 2;
            this.buttonUji.Text = "Uji";
            this.buttonUji.UseVisualStyleBackColor = true;
            this.buttonUji.Click += new System.EventHandler(this.buttonUji_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 489);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(826, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonUji);
            this.panel4.Controls.Add(this.buttonBuka);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(826, 34);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanelUji
            // 
            this.tableLayoutPanelUji.ColumnCount = 1;
            this.tableLayoutPanelUji.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUji.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanelUji.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanelUji.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanelUji.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanelUji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUji.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelUji.Name = "tableLayoutPanelUji";
            this.tableLayoutPanelUji.RowCount = 4;
            this.tableLayoutPanelUji.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelUji.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUji.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelUji.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelUji.Size = new System.Drawing.Size(832, 515);
            this.tableLayoutPanelUji.TabIndex = 1;
            // 
            // customPictureBoxHasil
            // 
            this.customPictureBoxHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxHasil.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxHasil.Image")));
            this.customPictureBoxHasil.Location = new System.Drawing.Point(416, 3);
            this.customPictureBoxHasil.Name = "customPictureBoxHasil";
            this.customPictureBoxHasil.Size = new System.Drawing.Size(407, 374);
            this.customPictureBoxHasil.TabIndex = 3;
            this.customPictureBoxHasil.Title = "Gambar Hasil Dekripsi";
            // 
            // customPictureBoxAsli
            // 
            this.customPictureBoxAsli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPictureBoxAsli.Image = ((System.Drawing.Bitmap)(resources.GetObject("customPictureBoxAsli.Image")));
            this.customPictureBoxAsli.Location = new System.Drawing.Point(3, 3);
            this.customPictureBoxAsli.Name = "customPictureBoxAsli";
            this.customPictureBoxAsli.Size = new System.Drawing.Size(407, 374);
            this.customPictureBoxAsli.TabIndex = 2;
            this.customPictureBoxAsli.Title = "Gambar Asli";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "El Gamal - Citra dan Teks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanelUji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCitra;
        private System.Windows.Forms.Panel panelCitra;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxTeks;
        private System.Windows.Forms.Panel panelTeks;
        private ElGamalKeyPanel elGamalKeyPanelCitra;
        private ElGamalKeyPanel elGamalKeyPanelTeks;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUji;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonUji;
        private System.Windows.Forms.Button buttonBuka;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private OlahCitra.CustomControl.CustomPictureBox customPictureBoxHasil;
        private OlahCitra.CustomControl.CustomPictureBox customPictureBoxAsli;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPSNR;
        private System.Windows.Forms.Label labelMSE;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}