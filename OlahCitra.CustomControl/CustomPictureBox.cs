﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.CustomControl
{
    public partial class CustomPictureBox : UserControl
    {
        public CustomPictureBox()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(300, 300);
            Title = "CustomPictureBox";

            pictureBox1.Click += new EventHandler(CustomPictureBox_Click);
        }

        private void CustomPictureBox_Click(object sender, EventArgs e)
        {
            if(_form == null || _form.IsDisposed == true)
            {
                _form = new Form();
                var pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Image;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Name = "pictureBox";

                _form.Text = Title;
                _form.WindowState = FormWindowState.Maximized;

                _form.Controls.Add(pictureBox);
                _form.Show();
            }
        }

        private Form _form;

        [Browsable(true)]
        public string Title { get => labelTitle.Text; set => labelTitle.Text = value; }

        [Browsable(true)]
        public Bitmap Image
        {
            get => new Bitmap(pictureBox1.Image);
            set 
            {
                pictureBox1.Image = value;

                if(_form != null && _form.IsDisposed == false)
                {
                     var controls = _form.Controls.Find("pictureBox", true);
                    (controls[0] as PictureBox).Image = value;
                }

                if(pictureBox1.Image != null)
                    labelResolusi.Text = $"Resolusi : {pictureBox1.Image.Width} X {pictureBox1.Image.Height}";
                else
                    labelResolusi.Text = "Resolusi : 0 X 0";
            }
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var formHistogram = new FormHistogram();
                formHistogram.SetHistogram(new Bitmap(pictureBox1.Image));
                formHistogram.Show();
            }
        }
    }
}
