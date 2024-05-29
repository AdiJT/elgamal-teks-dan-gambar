using ElGamal.Dekripsi.Contract;
using Emgu.CV;
using Emgu.CV.Structure;
using Newtonsoft.Json;
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

namespace ElGamal.Dekripsi
{
    public partial class DekripsiCitra : UserControl, IDeskripsi
    {
        public DekripsiCitra()
        {
            InitializeComponent();
        }

        public (long p, long x) KunciPrivat { get; set; }

        private Image<Bgr, int> _gambarCipher;
        private string _fileName = string.Empty;

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileName = new FileInfo(openFileDialog1.FileName).Name.Split('.')[0];
                
                using(StreamReader sr = new StreamReader(openFileDialog1.FileName))
                using(JsonReader reader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    var data = serializer.Deserialize<int[,,]>(reader);
                    _gambarCipher = new Image<Bgr, int>(data);
                }

                customPictureBoxCipher.Image = _gambarCipher.ToBitmap();
                customPictureBoxPlain.Image = null;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (customPictureBoxPlain.Image == null) return;

            saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
            saveFileDialog1.FileName = _fileName + " - Hasil Dekripsi";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                customPictureBoxPlain.Image.Save(saveFileDialog1.FileName);
            }
        }

        private async void buttonDekripsi_Click(object sender, EventArgs e)
        {
            await ProsesAsync();
        }

        private async Task ProsesAsync()
        {
            if (_gambarCipher == null) return;

            progressBar1.Value = 0;
            var progress = new Progress<int>((int v) => progressBar1.Value = Math.Min(progressBar1.Value + v, 100));
            var hasil = new Image<Bgr, byte>(_gambarCipher.Size);
            await Task.Run(() => hasil = Dekripsi(progress, _gambarCipher));
            progressBar1.Value = 0;

            customPictureBoxPlain.Image = hasil.ToBitmap();
        }

        private Image<Bgr, byte> Dekripsi(IProgress<int> progress, Image<Bgr, int> cipherImage)
        {
            var kunciPrivat = KunciPrivat;
            var hasil = new Image<Bgr, int>(cipherImage.Width / 2, cipherImage.Height);

            for(int x = 0; x < hasil.Width; x++)
            {
                for(int y = 0; y < hasil.Height; y++)
                {
                    for(int c = 0; c < 3; c++)
                    {
                        var a = (long)cipherImage.Data[y, x * 2, c];
                        var b = (long)cipherImage.Data[y, x * 2 + 1, c];

                        var m = ((b % kunciPrivat.p) * Utils.PangkatModulo(a, kunciPrivat.p - kunciPrivat.x - 1, kunciPrivat.p)) % kunciPrivat.p;

                        hasil.Data[y, x, c] = (int)m;
                    }
                }
            }

            return hasil.Convert<Bgr, byte>();
        }
    }
}
