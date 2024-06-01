namespace ElGamal
{
    partial class ElGamalKeyPanel
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
            this.components = new System.ComponentModel.Container();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1001, 118);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonGenerate);
            this.panel7.Controls.Add(this.groupBox3);
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1001, 118);
            this.panel7.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGenerate.Location = new System.Drawing.Point(897, 82);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(101, 28);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.textBoxX);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(496, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(401, 108);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kunci Privat";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(117, 48);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(276, 22);
            this.textBoxX.TabIndex = 3;
            this.textBoxX.Text = "0";
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            this.textBoxX.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxX_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bil. Acak x";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.buttonCek);
            this.groupBox4.Controls.Add(this.buttonHitung);
            this.groupBox4.Controls.Add(this.textBoxY);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxG);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxP);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(5, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(485, 108);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kunci Publik";
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(381, 18);
            this.buttonCek.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(101, 28);
            this.buttonCek.TabIndex = 7;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(381, 75);
            this.buttonHitung.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(101, 28);
            this.buttonHitung.TabIndex = 6;
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(117, 76);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(263, 22);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "y = g^x mod p";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(117, 48);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(263, 22);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.Text = "0";
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            this.textBoxG.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxG_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bil. Acak g";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(117, 20);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(263, 22);
            this.textBoxP.TabIndex = 1;
            this.textBoxP.Text = "0";
            this.textBoxP.TextChanged += new System.EventHandler(this.textBoxP_TextChanged);
            this.textBoxP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxP_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bil. Prima p";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ElGamalKeyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ElGamalKeyPanel";
            this.Size = new System.Drawing.Size(1001, 118);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonCek;
    }
}
