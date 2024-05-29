using ElGamal.Enkripsi.Contract;
using Emgu.CV;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal.Enkripsi
{
    public partial class EnkripsiCitra : UserControl, IEnkripsi
    {
        public EnkripsiCitra()
        {
            InitializeComponent();
        }

        public (long p, long g, long y) KunciPublik { get; set; }

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
            if (customPictureBoxAsli.Image == null) return;

            progressBar1.Value = 0;

            var progress = new Progress<int>((int v) => progressBar1.Value = Math.Min(progressBar1.Value +  v, 100));
            var hasil = new Image<Bgr, int>(customPictureBoxAsli.Image.Size);
            await Task.Run(() => hasil = Enkripsi(progress, customPictureBoxAsli.Image));
            progressBar1.Value = 0;

            customPictureBoxHasil.Image = hasil.Convert<Bgr, byte>().ToBitmap();

            _hasilEnkripsi = hasil;
        }

        private Image<Bgr, int> Enkripsi(IProgress<int> progress, Bitmap gambarAsli)
        {
            var kunciPublik = KunciPublik;

            var imageAsli = gambarAsli.ToImage<Bgr, int>();
            var gambarHasil = new Image<Bgr, int>(imageAsli.Width * 2, imageAsli.Height);

            var random = new Random();

            for (int x = 0; x < imageAsli.Width; x++)
            {
                for(int y = 0; y < imageAsli.Height; y++) 
                {
                    for(int c = 0; c < 3; c++)
                    {
                        var m = (long)imageAsli.Data[y, x, c];

                        var k = random.NextLong(0, kunciPublik.p);
                        var a = Utils.PangkatModulo(kunciPublik.g, k, kunciPublik.p);
                        var b = (Utils.PangkatModulo(kunciPublik.y, k, kunciPublik.p) * (m % kunciPublik.p)) % kunciPublik.p;

                        gambarHasil.Data[y, x * 2, c] = (int)a;
                        gambarHasil.Data[y, x * 2 + 1, c] = (int)b;
                    }
                }
                progress.Report((int)((10d / (double)imageAsli.Width) * 100d));
            }

            return gambarHasil;
        }
    }
}
