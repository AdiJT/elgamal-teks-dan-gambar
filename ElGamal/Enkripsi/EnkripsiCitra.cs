using ElGamal.Contracts;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Newtonsoft.Json;
using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal.Enkripsi
{
    public partial class EnkripsiCitra : UserControl, IEnkripsiDekripsiControl
    {
        public EnkripsiCitra()
        {
            InitializeComponent();
        }

        public ElGamalKey ElGamalKey { get; set; }
        public bool IsValid { get; set; }

        private string _fileName = string.Empty;
        private Image<Bgr, int> _hasilEnkripsi;

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var relativePath = new FileInfo(fileName).Name;

                _fileName = relativePath.Split('.')[0];

                var bitmap = new Bitmap(fileName);
                var grayScale = ImageProcessing.MakeGreyScale(bitmap);

                customPictureBoxAsli.Image = bitmap;

                customPictureBoxHasil.Image = null;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (customPictureBoxAsli.Image != null && customPictureBoxHasil.Image != null)
            {
                saveFileDialog1.Title = "Simpan Hasil Enkripsi - Gambar a";
                saveFileDialog1.FileName = _fileName + " - Hasil Enkripsi";
                saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (var streamWriter = new StreamWriter(saveFileDialog1.FileName))
                    using (var jsonWriter = new JsonTextWriter(streamWriter))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.Serialize(jsonWriter, _hasilEnkripsi.Data);
                    }
                }
            }
        }

        private async void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            await ProsesAsync();
        }

        private async Task ProsesAsync()
        {
            if (IsValid == false) return;
            if (customPictureBoxAsli.Image == null) return;

            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
            this.Enabled = false;

            var progress = new Progress<bool>((v) =>
            {
                if (v == true)
                    progressBar1.Style = ProgressBarStyle.Blocks;
            });

            var hasil = new Image<Bgr, int>(customPictureBoxAsli.Image.Size);
            await Task.Run(() => hasil = Enkripsi(progress, customPictureBoxAsli.Image));

            customPictureBoxHasil.Image = hasil.ToBitmap();

            _hasilEnkripsi = hasil;

            UpdateMSEPSNR();
            UpdateCrossEntropy();

            this.Enabled = true;
        }

        private void UpdateCrossEntropy()
        {
            var gambarAsli = customPictureBoxAsli.Image;
            var gambarEnkripsi = customPictureBoxHasil.Image;

            var histRGBAsli = ImageProcessing.MakeRGBHistogram(gambarAsli);
            var histGrayAsli = ImageProcessing.MakeGrayScaleHistogram(gambarAsli);

            var histRGBEnkripsi = ImageProcessing.MakeRGBHistogram(gambarEnkripsi);
            var histGrayEnkripsi = ImageProcessing.MakeGrayScaleHistogram(gambarEnkripsi);

            var ceR = Utils.CrossEntropy(
                histRGBAsli.histogramR.Select(i => (double)i / (double)histRGBAsli.histogramR.Sum()).ToArray(),
                histRGBEnkripsi.histogramR.Select(i => (double)i / (double)histRGBEnkripsi.histogramR.Sum()).ToArray());

            var ceG = Utils.CrossEntropy(
                histRGBAsli.histogramG.Select(i => (double)i / (double)histRGBAsli.histogramG.Sum()).ToArray(),
                histRGBEnkripsi.histogramG.Select(i => (double)i / (double)histRGBEnkripsi.histogramG.Sum()).ToArray());

            var ceB = Utils.CrossEntropy(
                histRGBAsli.histogramB.Select(i => (double)i / (double)histRGBAsli.histogramB.Sum()).ToArray(),
                histRGBEnkripsi.histogramB.Select(i => (double)i / (double)histRGBEnkripsi.histogramB.Sum()).ToArray());

            var ceGray = Utils.CrossEntropy(
                histGrayAsli.Select(i => (double)i / (double)histGrayAsli.Sum()).ToArray(),
                histGrayEnkripsi.Select(i => (double)i / (double)histGrayEnkripsi.Sum()).ToArray());

            labelCrossEntropyR.Text = $"Cross Entropy Histogram Red : {ceR:F3}";
            labelCrossEntropyGreen.Text = $"Cross Entropy Histogram Green : {ceG:F3}";
            labelCrossEntropyBlue.Text = $"Cross Entropy Histogram Blue : {ceB:F3}";
            labelCrossEntropyGrayScale.Text = $"Cross Entropy Histogram Gray Scale : {ceGray:F3}";
        }
        
        private void UpdateMSEPSNR()
        {
            var imageAsli = Utils.Padding(customPictureBoxAsli.Image, 3).ToImage<Bgr, int>();
            var imageAsliResized = new Image<Bgr, float>(imageAsli.Width * 2, imageAsli.Height);
            CvInvoke.Resize(imageAsli.Convert<Bgr, float>(), imageAsliResized, new Size(imageAsli.Width * 2, imageAsli.Height));

            (var mse, var psnr) = Utils.HitungMSEPSNR(imageAsliResized.Convert<Bgr, int>().Data, _hasilEnkripsi.Data);
            labelMSE.Text = $"MSE : {mse:F3}";
            labelPSNR.Text = $"PSNR : {psnr:F3}";
        }

        private Image<Bgr, int> Enkripsi(IProgress<bool> progress, Bitmap gambarAsli)
        {
            var kunciPublik = ElGamalKey.KunciPublik;

            var hasil = ElGamalCitra.Enkripsi(kunciPublik, gambarAsli);

            progress.Report(true);

            return hasil;
        }
    }
}
