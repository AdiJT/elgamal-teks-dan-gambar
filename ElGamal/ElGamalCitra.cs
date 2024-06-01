using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    public static class ElGamalCitra
    {
        public static Image<Bgr, int> Enkripsi((BigInteger P, BigInteger G, BigInteger Y) kunciPublik, Bitmap plain)
        {
            plain = Utils.Padding(plain, 3);
            var plainImage = plain.ToImage<Bgr, int>();
            var cipherImage = new Image<Bgr, int>(plainImage.Width * 2, plainImage.Height);

            var jumlahBlok = plainImage.Width / 3;

            var random = new Random();

            for (int y = 0; y < plainImage.Height; y++)
            {
                for(int blok = 0; blok < jumlahBlok; blok++)
                {
                    var pixelPertama = $"{plainImage.Data[y, blok * 3, 2]:D3}{plainImage.Data[y, blok * 3, 1]:D3}{plainImage.Data[y, blok * 3, 0]:D3}";
                    var pixelKedua = $"{plainImage.Data[y, blok * 3 + 1, 2]:D3}{plainImage.Data[y, blok * 3 + 1, 1]:D3}{plainImage.Data[y, blok * 3 + 1, 0]:D3}";
                    var pixelKetiga = $"{plainImage.Data[y, blok * 3 + 2, 2]:D3}{plainImage.Data[y, blok * 3 + 2, 1]:D3}{plainImage.Data[y, blok * 3 + 2, 0]:D3}";

                    var mString = pixelPertama + pixelKedua + pixelKetiga;
                    var m = BigInteger.Parse(mString);

                    var k = random.NextBigInt(1, kunciPublik.P - 1);
                    var a = Utils.PangkatModulo(kunciPublik.G, k, kunciPublik.P);
                    var b = Utils.PangkatModulo(kunciPublik.Y, k, kunciPublik.P) * (m % kunciPublik.P) % kunciPublik.P;

                    var aString = $"{a:D27}";
                    var bString = $"{b:D27}";

                    var pixelPertamaA = aString.Substring(0, 9);
                    var pixelKeduaA = aString.Substring(9, 9);
                    var pixelKetigaA = aString.Substring(18, 9);

                    cipherImage.Data[y, blok * 3, 2] = int.Parse(pixelPertamaA.Substring(0, 3));
                    cipherImage.Data[y, blok * 3, 1] = int.Parse(pixelPertamaA.Substring(3, 3));
                    cipherImage.Data[y, blok * 3, 0] = int.Parse(pixelPertamaA.Substring(6, 3));

                    cipherImage.Data[y, blok * 3 + 1, 2] = int.Parse(pixelKeduaA.Substring(0, 3));
                    cipherImage.Data[y, blok * 3 + 1, 1] = int.Parse(pixelKeduaA.Substring(3, 3));
                    cipherImage.Data[y, blok * 3 + 1, 0] = int.Parse(pixelKeduaA.Substring(6, 3));

                    cipherImage.Data[y, blok * 3 + 2, 2] = int.Parse(pixelKetigaA.Substring(0, 3));
                    cipherImage.Data[y, blok * 3 + 2, 1] = int.Parse(pixelKetigaA.Substring(3, 3));
                    cipherImage.Data[y, blok * 3 + 2, 0] = int.Parse(pixelKetigaA.Substring(6, 3));

                    var pixelPertamaB = bString.Substring(0, 9);
                    var pixelKeduaB = bString.Substring(9, 9);
                    var pixelKetigaB = bString.Substring(18, 9);

                    cipherImage.Data[y, plain.Width + blok * 3, 2] = int.Parse(pixelPertamaB.Substring(0, 3));
                    cipherImage.Data[y, plain.Width + blok * 3, 1] = int.Parse(pixelPertamaB.Substring(3, 3));
                    cipherImage.Data[y, plain.Width + blok * 3, 0] = int.Parse(pixelPertamaB.Substring(6, 3));

                    cipherImage.Data[y, plain.Width + blok * 3 + 1, 2] = int.Parse(pixelKeduaB.Substring(0, 3));
                    cipherImage.Data[y, plain.Width + blok * 3 + 1, 1] = int.Parse(pixelKeduaB.Substring(3, 3));
                    cipherImage.Data[y, plain.Width + blok * 3 + 1, 0] = int.Parse(pixelKeduaB.Substring(6, 3));

                    cipherImage.Data[y, plain.Width + blok * 3 + 2, 2] = int.Parse(pixelKetigaB.Substring(0, 3));
                    cipherImage.Data[y, plain.Width + blok * 3 + 2, 1] = int.Parse(pixelKetigaB.Substring(3, 3));
                    cipherImage.Data[y, plain.Width + blok * 3 + 2, 0] = int.Parse(pixelKetigaB.Substring(6, 3));
                }
            }

            return cipherImage;
        }

        public static Bitmap Dekripsi((BigInteger P, BigInteger X) kunciPrivat, Image<Bgr, int> cipher)
        {
            var plainImage = new Image<Bgr, int>(cipher.Width / 2, cipher.Height);

            var jumlahBlok = plainImage.Width / 3;

            for (int y = 0; y < plainImage.Height; y++)
            {
                for (int blok = 0; blok < jumlahBlok; blok++)
                {
                    var pixelPertamaA = $"{cipher.Data[y, blok * 3, 2]:D3}{cipher.Data[y, blok * 3, 1]:D3}{cipher.Data[y, blok * 3, 0]:D3}";
                    var pixelKeduaA = $"{cipher.Data[y, blok * 3 + 1, 2]:D3}{cipher.Data[y, blok * 3 + 1, 1]:D3}{cipher.Data[y, blok * 3 + 1, 0]:D3}";
                    var pixelKetigaA = $"{cipher.Data[y, blok * 3 + 2, 2]:D3}{cipher.Data[y, blok * 3 + 2, 1]:D3}{cipher.Data[y, blok * 3 + 2, 0]:D3}";
                    var aString = pixelPertamaA + pixelKeduaA + pixelKetigaA;
                    var a = BigInteger.Parse(aString);

                    var pixelPertamaB = $"{cipher.Data[y, plainImage.Width + blok * 3, 2]:D3}{cipher.Data[y, plainImage.Width + blok * 3, 1]:D3}{cipher.Data[y, plainImage.Width + blok * 3, 0]:D3}";
                    var pixelKeduaB = $"{cipher.Data[y, plainImage.Width + blok * 3 + 1, 2]:D3}{cipher.Data[y, plainImage.Width + blok * 3 + 1, 1]:D3}{cipher.Data[y, plainImage.Width + blok * 3 + 1, 0]:D3}";
                    var pixelKetigaB = $"{cipher.Data[y, plainImage.Width + blok * 3 + 2, 2]:D3}{cipher.Data[y, plainImage.Width + blok * 3 + 2, 1]:D3}{cipher.Data[y, plainImage.Width + blok * 3 + 2, 0]:D3}";
                    var bString = pixelPertamaB + pixelKeduaB + pixelKetigaB;
                    var b = BigInteger.Parse(bString);

                    var m = ((b % kunciPrivat.P) * Utils.PangkatModulo(a, kunciPrivat.P - kunciPrivat.X - 1, kunciPrivat.P)) % kunciPrivat.P;

                    var mString = $"{m:D27}";

                    var pixelPertama = mString.Substring(0, 9);
                    var pixelKedua = mString.Substring(9, 9);
                    var pixelKetiga = mString.Substring(18, 9);

                    plainImage.Data[y, blok * 3, 2] = int.Parse(pixelPertama.Substring(0, 3));
                    plainImage.Data[y, blok * 3, 1] = int.Parse(pixelPertama.Substring(3, 3));
                    plainImage.Data[y, blok * 3, 0] = int.Parse(pixelPertama.Substring(6, 3));

                    plainImage.Data[y, blok * 3 + 1, 2] = int.Parse(pixelKedua.Substring(0, 3));
                    plainImage.Data[y, blok * 3 + 1, 1] = int.Parse(pixelKedua.Substring(3, 3));
                    plainImage.Data[y, blok * 3 + 1, 0] = int.Parse(pixelKedua.Substring(6, 3));

                    plainImage.Data[y, blok * 3 + 2, 2] = int.Parse(pixelKetiga.Substring(0, 3));
                    plainImage.Data[y, blok * 3 + 2, 1] = int.Parse(pixelKetiga.Substring(3, 3));
                    plainImage.Data[y, blok * 3 + 2, 0] = int.Parse(pixelKetiga.Substring(6, 3));
                }
            }

            return plainImage.ToBitmap();
        }
    }
}
