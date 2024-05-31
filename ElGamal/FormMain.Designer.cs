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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCitra = new System.Windows.Forms.ComboBox();
            this.panelCitra = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxTeks = new System.Windows.Forms.ComboBox();
            this.panelTeks = new System.Windows.Forms.Panel();
            this.elGamalKeyPanelCitra = new ElGamal.ElGamalKeyPanel();
            this.elGamalKeyPanelTeks = new ElGamal.ElGamalKeyPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
    }
}