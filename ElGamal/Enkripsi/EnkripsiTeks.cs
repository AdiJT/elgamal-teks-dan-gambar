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

namespace ElGamal.Enkripsi
{
    public partial class EnkripsiTeks : UserControl, IEnkripsiDekripsiControl
    {
        public EnkripsiTeks()
        {
            InitializeComponent();
        }

        private string _fileName = string.Empty;
        private int[,] _hasilEnkripsi;
        private long _durasi;

        public ElGamalKey ElGamalKey { get; set; }
        public bool IsValid { get; set; }

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileString = File.ReadAllText(openFileDialog1.FileName);

                textBoxAsli.Text = fileString;
                textBoxHasilEnkripsi.Text = "";
                _fileName = new FileInfo(openFileDialog1.FileName).Name.Split('.')[0];
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (_hasilEnkripsi == null || string.IsNullOrEmpty(textBoxHasilEnkripsi.Text)) return;

            saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
            saveFileDialog1.FileName = _fileName + " - Hasil Enkripsi";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                using(JsonTextWriter js = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(js, _hasilEnkripsi);
                }
            }
        }

        private async Task ProsesAsync()
        {
            this.Enabled = false;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
            var progress = new Progress<bool> ( (v) => { if (v) progressBar1.Style = ProgressBarStyle.Blocks; } );

            var plainTeks = textBoxAsli.Text;
            var hasil = new int[plainTeks.Length, 2];

            await Task.Run(() => hasil = Enkripsi(progress, plainTeks));

            _hasilEnkripsi = hasil;

            if (_durasi >= 1000)
            {
                var inSeconds = _durasi / 1000d;
                var inMinutes = inSeconds / 60d;

                labelWaktu.Text = $"Lama Proses : {(int)inMinutes:D2} : {(int)inSeconds % 60:D2} {(int)_durasi % 1000} ms";
            }
            else
                labelWaktu.Text = $"Lama Proses : {_durasi} ms";

            var cipherTeks = JsonConvert.SerializeObject(_hasilEnkripsi, Formatting.Indented);

            textBoxHasilEnkripsi.Text = cipherTeks;

            this.Enabled = true;
        }

        private int[,] Enkripsi(IProgress<bool> progress, string plainTeks)
        {
            var kunciPublik = ElGamalKey.KunciPublik;

            Stopwatch stopwatch = Stopwatch.StartNew();
            var hasil = ElGamalTeks.Enkripsi(kunciPublik, plainTeks);
            stopwatch.Stop();
            _durasi = stopwatch.ElapsedMilliseconds;

            progress.Report(true);

            return hasil;
        }

        private async void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            if (IsValid == false) return;
            if (string.IsNullOrEmpty(textBoxAsli.Text)) return;

            await ProsesAsync();
        }
    }
}
