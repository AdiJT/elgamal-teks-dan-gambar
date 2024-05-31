using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class ElGamalKeyPanel : UserControl
    {
        public ElGamalKeyPanel()
        {
            InitializeComponent();  
            OnKeyChanged += (s, e) => UpdateTextBox();
        }

        [Browsable(false)]
        public ElGamalKey ElGamalKey { get; set; }

        [Browsable(true)]
        public bool IsValid { get; set; }

        [Browsable(true)]
        public int JumlahDigitKunci { get; set; } = 3;

        [Browsable(true)]
        public string MinimalKunci { get; set; } = "255";

        [Browsable(true)]
        public event EventHandler OnKeyChanged;

        [Browsable(true)]
        public event EventHandler IsValidChanged;
        
        private void UpdateTextBox()
        {
            textBoxP.Text = ElGamalKey.P.ToString();
            textBoxG.Text = ElGamalKey.G.ToString();
            textBoxY.Text = ElGamalKey.Y.ToString();
            textBoxX.Text = ElGamalKey.X.ToString();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ElGamalKey = new ElGamalKey(JumlahDigitKunci, BigInteger.Parse(MinimalKunci));

            if (IsValid == false)
            {
                IsValid = true;
                IsValidChanged?.Invoke(this, EventArgs.Empty);
            }
            OnKeyChanged?.Invoke(this, EventArgs.Empty);
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (!IsValid) return;

            var p = ElGamalKey.P;
            var g = ElGamalKey.G;
            var x = ElGamalKey.X;

            var y = Utils.PangkatModulo(g, x, p);
            ElGamalKey.Y = y;
            OnKeyChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {
            ElGamalKey.P = BigInteger.Parse(textBoxP.Text);
            OnKeyChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            ElGamalKey.G = BigInteger.Parse(textBoxG.Text);
            OnKeyChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            ElGamalKey.X = BigInteger.Parse(textBoxX.Text);
            OnKeyChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBoxP_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxP, null);

            try
            {
                var pString = textBoxP.Text;

                if (string.IsNullOrEmpty(pString) == true) throw new Exception("Belum diisi");
                if (BigInteger.TryParse(pString, out var p) == false) throw new Exception("Bukan Angka!");
                if (Utils.CekPrimaLehman(p) == false) throw new Exception("Bukan Prima!");
                if (p < BigInteger.Parse(MinimalKunci)) throw new Exception("p lebih kecil dari " + MinimalKunci);

                if(IsValid == false)
                {
                    IsValid = true;
                    IsValidChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxP, ex.Message);

                if(IsValid == true)
                {
                    IsValid = false;
                    IsValidChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void textBoxG_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxG, null);

            try
            {
                var gString = textBoxG.Text;

                if (string.IsNullOrEmpty(gString) == true) throw new Exception("Belum diisi");
                if (BigInteger.TryParse(gString, out var g) == false) throw new Exception("Bukan Angka!");
                if (g >= ElGamalKey.P) throw new Exception("g lebih besar dari prima p");

                if (IsValid == false)
                {
                    IsValid = true;
                    IsValidChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxG, ex.Message);

                if (IsValid == true)
                {
                    IsValid = false;
                    IsValidChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void textBoxX_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxX, null);

            try
            {
                var xString = textBoxX.Text;

                if (string.IsNullOrEmpty(xString) == true) throw new Exception("Belum diisi");
                if (BigInteger.TryParse(xString, out var x) == false) throw new Exception("Bukan Angka!");
                if (x >= ElGamalKey.P) throw new Exception("x lebih besar dari prima p - 1");

                if (IsValid == false)
                {
                    IsValid = true;
                    IsValidChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxX, ex.Message);

                if (IsValid == true)
                {
                    IsValid = false;
                    IsValidChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
