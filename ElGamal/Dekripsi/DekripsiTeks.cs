using ElGamal.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal.Dekripsi
{
    public partial class DekripsiTeks : UserControl, IEnkripsiDekripsiControl
    {
        public DekripsiTeks()
        {
            InitializeComponent();
        }

        public ElGamalKey ElGamalKey { get; set; }
        public bool IsValid { get; set; }

        private int[,] _cipherTeks;
        private string _fileName = string.Empty;
        private long _durasi;

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                using (JsonReader  jsonReader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    _cipherTeks = serializer.Deserialize<int[,]>(jsonReader);

                    var teks = JsonConvert.SerializeObject(_cipherTeks, Formatting.Indented);
                    textBoxCipher.Text = teks;
                }

                _fileName = new FileInfo(openFileDialog1.FileName).Name.Split('.')[0];
                textBoxHasilDekripsi.Text = string.Empty;
            }
        }

        private async void buttonDeskripsi_Click(object sender, EventArgs e)
        {
            if (IsValid == false) return;
            if (_cipherTeks == null) return;

            await ProsesAsync();
        }

        private async Task ProsesAsync()
        {
            this.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value = 0;
            var progress = new Progress<bool>(v => { if (v) progressBar1.Style = ProgressBarStyle.Blocks; });

            string hasil = string.Empty;
            await Task.Run(() => hasil = Dekripsi(progress, _cipherTeks));

            if (_durasi >= 1000)
            {
                var inSeconds = _durasi / 1000d;
                var inMinutes = inSeconds / 60d;

                labelWaktu.Text = $"Lama Proses : {(int)inMinutes:D2} menit  {(int)inSeconds % 60:D2} detik {(int)_durasi % 1000} ms";
            }
            else
                labelWaktu.Text = $"Lama Proses : {_durasi} ms";

            progressBar1.Value = 0;

            textBoxHasilDekripsi.Text = hasil;
            this.Enabled = true;
        }

        private string Dekripsi(IProgress<bool> progress, int[,] cipherTeks)
        {
            var kunciPrivat = ElGamalKey.KunciPrivat;

            var stopwatch = Stopwatch.StartNew();
            var hasil = ElGamalTeks.Dekripsi(kunciPrivat, cipherTeks);
            stopwatch.Stop();
            _durasi = stopwatch.ElapsedMilliseconds;

            progress.Report(true);
            return hasil;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHasilDekripsi.Text)) return;

            saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
            saveFileDialog1.FileName = _fileName + " - Hasil Dekripsi";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string plainTeks = textBoxHasilDekripsi.Text;

                File.WriteAllText(saveFileDialog1.FileName, plainTeks);
            }
        }
    }
    
}
