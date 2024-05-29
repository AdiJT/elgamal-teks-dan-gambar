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
        }

        public long P { get => long.Parse(textBoxP.Text); set => textBoxP.Text = value.ToString(); }
        public long G { get => long.Parse(textBoxG.Text); set => textBoxG.Text = value.ToString(); }
        public long Y { get => long.Parse(textBoxY.Text); set => textBoxY.Text = value.ToString(); }
        public long X { get => long.Parse(textBoxX.Text); set => textBoxX.Text = value.ToString(); }

        public async Task<T> ProsesAsync<T>(Func<IProgress<bool>, T> action)
        {
            progressBar1.Visible = true;

            var progress = new Progress<bool>((bool b) =>
            {
                progressBar1.Visible = b;
            });

            return await Task.Run(() => action(progress));
        }

        private async void buttonGenerate_ClickAsync(object sender, EventArgs e)
        {
            var hasil = await ProsesAsync(GenerateKunci);

            P = hasil.p;
            G = hasil.g;
            Y = hasil.y;
            X = hasil.x;
        }

        private (long p, long g, long y, long x) GenerateKunci(IProgress<bool> progress) 
        {
            var p = Utils.RandomPrime(9, 10, min: 255255255);

            var random = new Random();

            var g = random.NextLong(1, p);
            var x = random.NextLong(1, p - 1);
            var y = Utils.PangkatModulo(g, x, p);

            progress.Report(false);

            return (p, g, y, x);
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (P <= 0 || G <= 0 || Y <= 0) return;

            var p = P;
            var g = G;
            var x = X;

            Y = Utils.PangkatModulo(g, x, p);
        }

        private void textBoxP_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxP, null);

            try
            {
                if (string.IsNullOrEmpty(textBoxP.Text)) throw new Exception("Belum diisi");
                if (!Utils.CekPrimaLehman(P, 6)) throw new Exception("Bilangan Bukan Prima");
                if (P <= 255255255) throw new Exception("Bilangan lebih kecil dari 255255255");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxP, ex.Message);
            }
        }

        private void textBoxG_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxG, null);

            try
            {
                if (string.IsNullOrEmpty(textBoxG.Text)) throw new Exception("Belum diisi");
                if (G <= 0) throw new Exception("Bilangan nol atau negatif");
                if (G >= P) throw new Exception("Bilangan lebih besar dari Prima P");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxG, ex.Message);
            }
        }

        private void textBoxX_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxX, null);

            try
            {
                if (string.IsNullOrEmpty(textBoxX.Text)) throw new Exception("Belum diisi");
                if (X <= 0) throw new Exception("Bilangan nol atau negatif");
                if (X >= P - 1) throw new Exception("Bilangan lebih besar dari Prima P - 1");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxX, ex.Message);
            }
        }

        private async void FormMain_LoadAsync(object sender, EventArgs e)
        {
            comboBoxJenisEnkripsi.SelectedText = "Citra";

            var hasil = await ProsesAsync(GenerateKunci);

            P = hasil.p;
            G = hasil.g;
            Y = hasil.y;
            X = hasil.x;
        }
    }
}
