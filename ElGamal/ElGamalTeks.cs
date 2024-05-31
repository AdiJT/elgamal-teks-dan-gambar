using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    public static class ElGamalTeks
    {
        public static int[,] Enkripsi((BigInteger P, BigInteger G, BigInteger Y) kunciPublik, string plain)
        {
            plain = Utils.Padding(plain, 3);
            var plainBytes = Encoding.UTF8.GetBytes(plain);
            var cipher = new int[plain.Length, 2];

            var jumlahBlok = plain.Length / 3;

            var random = new Random();
            for(int blok = 0; blok < jumlahBlok; blok++)
            {
                var mString = $"{plainBytes[blok * 3]:D3}{plainBytes[blok * 3 + 1]:D3}{plainBytes[blok * 3 + 2]:D3}";

                var m = BigInteger.Parse(mString);
                var k = random.NextBigInt(1, kunciPublik.P - 1);
                var a = Utils.PangkatModulo(kunciPublik.G, k, kunciPublik.P);
                var b = Utils.PangkatModulo(kunciPublik.Y, k, kunciPublik.P) * (m % kunciPublik.P) % kunciPublik.P;

                var aString = $"{a:D9}";
                var bString = $"{b:D9}";

                cipher[blok * 3, 0] = int.Parse(aString.Substring(0, 3));
                cipher[blok * 3, 1] = int.Parse(bString.Substring(0, 3));

                cipher[blok * 3 + 1, 0] = int.Parse(aString.Substring(3, 3));
                cipher[blok * 3 + 1, 1] = int.Parse(bString.Substring(3, 3));

                cipher[blok * 3 + 2, 0] = int.Parse(aString.Substring(6, 3));
                cipher[blok * 3 + 2, 1] = int.Parse(bString.Substring(6, 3));
            }

            return cipher;
        }

        public static string Dekripsi((BigInteger P, BigInteger X) kunciPrivat, int[,] cipher)
        {
            if (cipher.GetLength(1) != 2) throw new ArgumentOutOfRangeException("cipher second dimension");

            byte[] plainBytes = new byte[cipher.GetLength(0)];
            var jumlahBlok = cipher.GetLength(0) / 3;

            for(int blok = 0; blok < jumlahBlok; blok++)
            {
                var aString = $"{cipher[blok * 3, 0]:D3}{cipher[blok * 3 + 1, 0]:D3}{cipher[blok * 3 + 2, 0]:D3}";
                var bString = $"{cipher[blok * 3, 1]:D3}{cipher[blok * 3 + 1, 1]:D3}{cipher[blok * 3 + 2, 1]:D3}";

                var a = BigInteger.Parse(aString);
                var b = BigInteger.Parse(bString);

                var m = ((b % kunciPrivat.P) * Utils.PangkatModulo(a, kunciPrivat.P - kunciPrivat.X - 1, kunciPrivat.P)) % kunciPrivat.P;
                var mString = $"{m:D9}";

                plainBytes[blok * 3] = (byte)int.Parse(mString.Substring(0, 3));
                plainBytes[blok * 3 + 1] = (byte)int.Parse(mString.Substring(3, 3));
                plainBytes[blok * 3 + 2] = (byte)int.Parse(mString.Substring(6, 3));
            }

            string plain = Encoding.UTF8.GetString(plainBytes);

            return plain;
        }
    }
}
