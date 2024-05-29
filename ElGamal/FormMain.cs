using ElGamal.Dekripsi;
using ElGamal.Dekripsi.Contract;
using ElGamal.Enkripsi;
using ElGamal.Enkripsi.Contract;
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
            
            OnKunciPublikChanged += KunciPublikChanged;
            _activeEnkripsi = _enkripsiCitra;
            panelEnkripsi.Controls.Add(_enkripsiCitra);

            OnKunciPrivatChanged += KunciPrivatChanged;
            _activeDeskripsi = _deskripsiCitra;
            panelDeskripsi.Controls.Add(_deskripsiCitra);
        }

        public long P { get => long.Parse(textBoxP.Text); set => textBoxP.Text = value.ToString(); }
        public long G { get => long.Parse(textBoxG.Text); set => textBoxG.Text = value.ToString(); }
        public long Y { get => long.Parse(textBoxY.Text); set => textBoxY.Text = value.ToString(); }
        public long X { get => long.Parse(textBoxX.Text); set => textBoxX.Text = value.ToString(); }

        private IEnkripsi _activeEnkripsi;
        private EnkripsiCitra _enkripsiCitra = new EnkripsiCitra() { Dock = DockStyle.Fill };
        private EnkripsiTeks _enkripsiTeks = new EnkripsiTeks() { Dock = DockStyle.Fill };

        private IDeskripsi _activeDeskripsi;
        private DekripsiCitra _deskripsiCitra = new DekripsiCitra() { Dock = DockStyle.Fill };
        private DeskripsiTeks _deskripsiTeks = new DeskripsiTeks() { Dock = DockStyle.Fill };

        public event EventHandler OnKunciPublikChanged;
        public event EventHandler OnKunciPrivatChanged;

        public async Task<T> ProsesAsync<T>(Func<T> action)
        { 
            return await Task.Run(() => action());
        }

        public void KunciPublikChanged(object sender, EventArgs e)
        {
            _activeEnkripsi.KunciPublik = (P, G, Y);
        }

        public void KunciPrivatChanged(object sender, EventArgs e)
        {
            _activeDeskripsi.KunciPrivat = (P, X);
        }

        private async void buttonGenerate_ClickAsync(object sender, EventArgs e)
        {
            var hasil = await ProsesAsync(GenerateKunci);

            P = hasil.p;
            G = hasil.g;
            Y = hasil.y;
            X = hasil.x;

            OnKunciPublikChanged?.Invoke(this, EventArgs.Empty);
            OnKunciPrivatChanged?.Invoke(this, EventArgs.Empty);
        }

        private (long p, long g, long y, long x) GenerateKunci() 
        {
            var p = Utils.RandomPrime(3, 4, min: 255);

            var random = new Random();

            var g = random.NextLong(1, p);
            var x = random.NextLong(1, p - 1);
            var y = Utils.PangkatModulo(g, x, p);
            return (p, g, y, x);
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (P <= 0 || G <= 0 || Y <= 0) return;

            var p = P;
            var g = G;
            var x = X;

            Y = Utils.PangkatModulo(g, x, p);

            OnKunciPublikChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxP_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxP, null);

            try
            {
                if (string.IsNullOrEmpty(textBoxP.Text)) throw new Exception("Belum diisi");
                if (!Utils.CekPrimaLehman(P, 6)) throw new Exception("Bilangan Bukan Prima");
                if (P <= 255) throw new Exception("Bilangan lebih kecil dari 255255255");
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
            comboBoxJenisDekripsi.SelectedItem = "Citra";

            var hasil = await ProsesAsync(GenerateKunci);

            P = hasil.p;
            G = hasil.g;
            Y = hasil.y;
            X = hasil.x;
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {
            OnKunciPublikChanged?.Invoke(this, EventArgs.Empty);
            OnKunciPrivatChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            OnKunciPublikChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            OnKunciPublikChanged?.Invoke(this, EventArgs.Empty);
        }

        private void comboBoxJenisEnkripsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBoxJenisEnkripsi.SelectedItem == "Citra")
            {
                panelEnkripsi.Controls.Clear();
                panelEnkripsi.Controls.Add(_enkripsiCitra);
                _activeEnkripsi = _enkripsiCitra;
            }
            else
            {
                panelEnkripsi.Controls.Clear();
                panelEnkripsi.Controls.Add(_enkripsiTeks);
                _activeEnkripsi = _enkripsiTeks;
            }

            OnKunciPublikChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            OnKunciPrivatChanged?.Invoke(this, EventArgs.Empty);
        }

        private void comboBoxJenisDekripsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxJenisDekripsi.SelectedItem == "Citra")
            {
                panelDeskripsi.Controls.Clear();
                panelDeskripsi.Controls.Add(_deskripsiCitra);
                _activeDeskripsi = _deskripsiCitra;
            }
            else
            {
                panelDeskripsi.Controls.Clear();
                panelDeskripsi.Controls.Add(_deskripsiTeks);
                _activeDeskripsi = _deskripsiTeks;
            }

            OnKunciPrivatChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
