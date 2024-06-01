using ElGamal.Contracts;
using ElGamal.Dekripsi;
using ElGamal.Enkripsi;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            _activeCitra = _enkripsiCitra;
            _activeTeks = _enkripsiTeks;

            panelCitra.Controls.Clear();
            panelCitra.Controls.Add(_enkripsiCitra);
            _enkripsiCitra.ElGamalKey = elGamalKeyPanelCitra.ElGamalKey;
            _enkripsiCitra.IsValid = elGamalKeyPanelCitra.IsValid;
            comboBoxCitra.SelectedItem = "Enkripsi";

            panelTeks.Controls.Clear();
            panelTeks.Controls.Add(_enkripsiTeks);
            _enkripsiTeks.ElGamalKey = elGamalKeyPanelTeks.ElGamalKey;
            _enkripsiTeks.IsValid = elGamalKeyPanelTeks.IsValid;
            comboBoxTeks.SelectedItem = "Enkripsi";
        }

        private IEnkripsiDekripsiControl _activeCitra;
        private readonly EnkripsiCitra _enkripsiCitra = new EnkripsiCitra() { Dock = DockStyle.Fill };
        private readonly DekripsiCitra _dekripsiCitra = new DekripsiCitra() { Dock = DockStyle.Fill };

        private IEnkripsiDekripsiControl _activeTeks;
        private readonly EnkripsiTeks _enkripsiTeks = new EnkripsiTeks() { Dock = DockStyle.Fill };
        private readonly DekripsiTeks _dekripsiTeks = new DekripsiTeks() { Dock = DockStyle.Fill };

        private void elGamalKeyPanelCitra_OnKeyChanged(object sender, EventArgs e)
        {
            _activeCitra.ElGamalKey = elGamalKeyPanelCitra.ElGamalKey;
        }

        private void elGamalKeyPanelTeks_OnKeyChanged(object sender, EventArgs e)
        {
            _activeTeks.ElGamalKey = elGamalKeyPanelTeks.ElGamalKey;
        }

        private void elGamalKeyPanelCitra_IsValidChanged(object sender, EventArgs e)
        {
            _activeCitra.IsValid = elGamalKeyPanelCitra.IsValid;
        }

        private void elGamalKeyPanelTeks_IsValidChanged(object sender, EventArgs e)
        {
            _activeTeks.IsValid = elGamalKeyPanelTeks.IsValid;
        }

        private void comboBoxCitra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCitra.SelectedItem as string == "Enkripsi")
            {
                _activeCitra = _enkripsiCitra;

                panelCitra.Controls.Clear();
                panelCitra.Controls.Add(_enkripsiCitra);
            }
            else
            {
                _activeCitra = _dekripsiCitra;

                panelCitra.Controls.Clear();
                panelCitra.Controls.Add(_dekripsiCitra);
            }

            _activeCitra.ElGamalKey = elGamalKeyPanelCitra.ElGamalKey;
            _activeCitra.IsValid = elGamalKeyPanelCitra.IsValid;
        }

        private void comboBoxTeks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeks.SelectedItem as string == "Enkripsi")
            {
                _activeTeks = _enkripsiTeks;

                panelTeks.Controls.Clear();
                panelTeks.Controls.Add(_enkripsiTeks);
            }
            else
            {
                _activeTeks = _dekripsiTeks;

                panelTeks.Controls.Clear();
                panelTeks.Controls.Add(_dekripsiTeks);
            }

            _activeTeks.ElGamalKey = elGamalKeyPanelTeks.ElGamalKey;
            _activeTeks.IsValid = elGamalKeyPanelTeks.IsValid;
        }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                customPictureBoxAsli.Image = new Bitmap(fileName);
                customPictureBoxHasil.Image = null;
            }
        }

        private async void buttonUji_Click(object sender, EventArgs e)
        {
            if (elGamalKeyPanelCitra.IsValid == false) return;
            await ProsesAsync();
        }

        private async Task ProsesAsync()
        {
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
            tableLayoutPanelUji.Enabled = false;

            var progress = new Progress<Bitmap>(
                v => 
                {
                    customPictureBoxHasil.Image = v;
                }
            );

            var asli = customPictureBoxAsli.Image;
            var hasil = new Bitmap(asli.Width, asli.Height);

            await Task.Run(() => hasil = UjiHasilDekripsi(progress, asli));

            customPictureBoxHasil.Image = hasil;

            UpdateMSEPSNR();

            tableLayoutPanelUji.Enabled = true;
            progressBar1.Style = ProgressBarStyle.Blocks;
        }

        private void UpdateMSEPSNR()
        {
            var asli = customPictureBoxAsli.Image;
            var hasil = customPictureBoxHasil.Image;

            asli = Utils.Padding(asli);

            var msePSNR = Utils.HitungMSEPSNR(asli.ToImage<Bgr, int>().Data, hasil.ToImage<Bgr, int>().Data);

            labelMSE.Text = $"MSE : {msePSNR.MSE}";
            labelPSNR.Text = $"PSNR : {msePSNR.PSNR}";
        }

        private Bitmap UjiHasilDekripsi(IProgress<Bitmap> progress, Bitmap asli)
        {
            var enkripsi = ElGamalCitra.Enkripsi(elGamalKeyPanelCitra.ElGamalKey.KunciPublik, asli);
            progress.Report(enkripsi.ToBitmap());

            var dekripsi = ElGamalCitra.Dekripsi(elGamalKeyPanelCitra.ElGamalKey.KunciPrivat, enkripsi);
            progress.Report(dekripsi);

            return dekripsi;
        }
    }
}
