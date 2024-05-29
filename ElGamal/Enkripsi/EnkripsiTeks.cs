using ElGamal.Enkripsi.Contract;
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

namespace ElGamal.Enkripsi
{
    public partial class EnkripsiTeks : UserControl, IEnkripsi
    {
        public EnkripsiTeks()
        {
            InitializeComponent();
        }

        public (long p, long g, long y) KunciPublik { get; set; }
        private string _fileName = string.Empty;
        private int[,] _hasilEnkripsi;

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
            progressBar1.Value = 0;
            var progress = new Progress<int>((v) => progressBar1.Value = Math.Min(progressBar1.Value + v, progressBar1.Maximum));

            var plainTeks = textBoxAsli.Text;
            var hasil = new int[plainTeks.Length, 2];

            await Task.Run(() => hasil = Enkripsi(progress, plainTeks));

            _hasilEnkripsi = hasil;
            var cipherTeks = "";

            for (int i = 0; i < _hasilEnkripsi.GetLength(0); i++)
            {
                cipherTeks += $"a : {_hasilEnkripsi[i, 0]} b : {_hasilEnkripsi[i, 1]}";
                if (i != _hasilEnkripsi.GetLength(0) - 1)
                    cipherTeks += ", ";
            }

            textBoxHasilEnkripsi.Text = cipherTeks;
        }

        private int[,] Enkripsi(IProgress<int> progress, string plainTeks)
        {
            var hasil = new int[plainTeks.Length, 2];
            var kunciPublik = KunciPublik;
            var random = new Random();

            for(int i = 0; i < plainTeks.Length; i++)
            {
                var mChar = plainTeks[i];
                var m = (long)(int)mChar;
                var k = random.NextLong(0, kunciPublik.p);
                var a = Utils.PangkatModulo(kunciPublik.g, k, kunciPublik.p);
                var b = (Utils.PangkatModulo(kunciPublik.y, k, kunciPublik.p) * (m % kunciPublik.p)) % kunciPublik.p;
                hasil[i, 0] = (int)a;
                hasil[i, 1] = (int)b;
            }

            return hasil;
        }

        private async void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAsli.Text)) return;

            await ProsesAsync();
        }
    }
}
