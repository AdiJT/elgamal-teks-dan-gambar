using ElGamal.Contracts;
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
    public partial class DekripsiCitra : UserControl, IEnkripsiDekripsiControl
    {
        public DekripsiCitra()
        {
            InitializeComponent();
        }

        public ElGamalKey ElGamalKey { get; set; }
        public bool IsValid { get; set; }

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
            if (IsValid == false) return;
            if (_gambarCipher == null) return;

            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
            this.Enabled = false;

            var progress = new Progress<bool>((v) =>
            {
                if (v == true)
                    progressBar1.Style = ProgressBarStyle.Blocks;
            });

            var hasil = new Bitmap(_gambarCipher.Width / 2, _gambarCipher.Height);
            await Task.Run(() => hasil = Dekripsi(progress, _gambarCipher));

            progressBar1.Value = 0;
            this.Enabled = true;

            customPictureBoxPlain.Image = hasil;
        }

        private Bitmap Dekripsi(IProgress<bool> progress, Image<Bgr, int> cipherImage)
        {
            var kunciPrivat = ElGamalKey.KunciPrivat;

            var hasil = ElGamalCitra.Dekripsi(kunciPrivat, cipherImage);
            progress.Report(true);

            return hasil;
        }
    }
}
