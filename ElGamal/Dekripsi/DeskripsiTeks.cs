using ElGamal.Dekripsi.Contract;
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
    public partial class DeskripsiTeks : UserControl, IDeskripsi
    {
        public DeskripsiTeks()
        {
            InitializeComponent();
        }

        public (long p, long x) KunciPrivat { get; set; }

        private int[,] _cipherTeks;
        private string _fileName = string.Empty;

        private void buttonBuka_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                using (JsonReader  jsonReader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    _cipherTeks = serializer.Deserialize<int[,]>(jsonReader);

                    var teks = "";

                    for (int i = 0; i < _cipherTeks.GetLength(0); i++)
                    {
                        teks += $"a : {_cipherTeks[i, 0]} b : {_cipherTeks[i, 1]}";
                        if (i != _cipherTeks.GetLength(0) - 1)
                            teks += ", ";
                    }
                    textBoxCipher.Text = teks;
                }

                _fileName = new FileInfo(openFileDialog1.FileName).Name.Split('.')[0];
                textBoxHasilDekripsi.Text = string.Empty;
            }
        }

        private async void buttonDeskripsi_Click(object sender, EventArgs e)
        {
            if (_cipherTeks == null) return;

            await ProsesAsync();
        }

        private async Task ProsesAsync()
        {
            progressBar1.Value = 0;
            var progress = new Progress<int>(v => progressBar1.Value = Math.Min(progressBar1.Maximum, progressBar1.Value + v));

            string hasil = string.Empty;
            await Task.Run(() => hasil = Dekripsi(progress, _cipherTeks));
            progressBar1.Value = 0;

            textBoxHasilDekripsi.Text = hasil;
        }

        private string Dekripsi(IProgress<int> progress, int[,] cipherTeks)
        {
            var kunciPrivat = KunciPrivat;
            string hasil = "";

            for(int i = 0; i < cipherTeks.GetLength(0); i++)
            {
                var a = (long)cipherTeks[i, 0];
                var b = (long)cipherTeks[i, 1];

                var m = ((b % kunciPrivat.p) * Utils.PangkatModulo(a, kunciPrivat.p - kunciPrivat.x - 1, kunciPrivat.p)) % kunciPrivat.p;

                hasil += UTF8Encoding.UTF8.GetString(new byte[] { (byte)m });
            }

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
