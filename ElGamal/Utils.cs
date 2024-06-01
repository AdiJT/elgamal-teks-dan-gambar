using System;
using System.Numerics;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ElGamal
{
    public static class Utils
    {
        public static double CrossEntropy(double[] p, double[] q)
        {
            if (p.Length != q.Length) throw new ArgumentException("Panjang p dan q tidak sama");

            var crossEntropy = 0d;

            for(int i = 0; i < p.Length; i++)
            {
                var h = p[i] * (q[i] == 0 ? 0 : Math.Log(q[i], 2));
                crossEntropy += h;
            }

            return -1 * crossEntropy;
        }

        public static (double MSE, double PSNR) HitungMSEPSNR(int[,,] p, int[,,] q)
        {
            if (p.GetLength(0) != q.GetLength(0) || p.GetLength(1) != q.GetLength(1) || p.GetLength(2) != q.GetLength(2))
                throw new ArgumentException();

            double total = 0;
            double mse = 0;
            double psnr = 0;

            for (int x = 0; x < p.GetLength(0); x++)
                for (int y = 0; y < p.GetLength(1); y++)
                {
                    for(int c = 0; c < p.GetLength(2); c++)
                    {
                        var selisih = Math.Pow(p[x, y, c] - q[x, y, c], 2);
                        total += selisih;
                    }
                }

            mse = total / (p.GetLength(0) * p.GetLength(1) * p.GetLength(2));
            psnr = 10 * Math.Log10(255 * 255 / mse);

            return (mse, psnr);
        }

        public static int Max(int[,,] p)
        {
            var max = int.MinValue;

            for (int x = 0; x < p.GetLength(0); x++)
                for (int y = 0; y < p.GetLength(1); y++)
                {
                    for (int c = 0; c < p.GetLength(2); c++)
                    {
                        if (p[x, y, c] > max)
                            max = p[x, y, c];
                    }
                }

            return max;
        }

        public static long PangkatModulo(long a, long n, long m)
        {
            var bits = Int64ToBit(n);
            long hasil = 1;

            for(int i = 0; i < bits.Length; i++)
            {
                hasil = (hasil * hasil) % m;
                if (bits[i] == 1)
                    hasil = (hasil * a) % m;
            }

            return hasil;
        }

        public static BigInteger PangkatModulo(BigInteger a, BigInteger n, BigInteger m)
        {
            var bits = BigIntToBits(n);
            BigInteger hasil = 1;

            for (int i = 0; i < bits.Length; i++)
            {
                hasil = (hasil * hasil) % m;
                if (bits[i] == 1)
                    hasil = (hasil * a) % m;
            }

            return hasil;
        }

        public static int[] BigIntToBits(BigInteger b)
        {
            if (b == 0) return new int[] { 0 };

            List<int> bits = new List<int>();

            while (b > 0)
            {
                bits.Add((int)(b % 2));
                b >>= 1;
            }

            bits.Reverse();

            return bits.ToArray();
        }

        public static int[] Int64ToBit(long b)
        {
            if (b == 0) return new int[] { 0 };

            List<int> bits = new List<int>();

            while(b > 0)
            {
                bits.Add((int)(b % 2L));
                b >>= 1;
            }

            bits.Reverse();

            return bits.ToArray();
        }

        public static long Square(long n)
        {
            var hasil =  n * n;

            if(hasil < n) throw new OverflowException();

            return hasil;
        }

        static readonly long[] primes = new long[]
        {
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107,
            109, 113, 127, 131, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 199, 211, 223, 227, 229, 233, 239,
            241, 251
        };

        public static bool CekPrimaLehman(long prime, int banyakPengujian)
        {
            if (prime <= 256) return primes.Contains(prime);

            //Bagi dengan bil. prima < 256
            foreach (var nilai in primes)
                if (prime % nilai == 0) return false;

            var random = new Random();
            var listAngkaUji = new List<int>();
            var listHasilUji = new List<long>();
            var pangkat = (prime - 1) / 2L;
            for (int i = 0; i < banyakPengujian; i++)
            {
                int a = 0;

                do
                {
                    a = random.Next(100);
                } while (listAngkaUji.Contains(a));
                listAngkaUji.Add(a);

                var uji = PangkatModulo(a, pangkat, prime);
                if (uji != 1 && uji != -1 && uji != prime - 1) return false;
                listHasilUji.Add(uji);
            }

            return true;
        }

        public static bool CekPrimaLehman(BigInteger prime, int banyakPengujian = 6)
        {
            if (prime <= 256) return primes.Contains((long)prime);

            //Bagi dengan bil. prima < 256
            foreach (var nilai in primes)
                if (prime % nilai == 0) return false;

            var random = new Random();
            var listAngkaUji = new List<int>();
            var listHasilUji = new List<BigInteger>();
            var pangkat = (prime - 1) / 2L;
            for (int i = 0; i < banyakPengujian; i++)
            {
                int a = 0;

                do
                {
                    a = random.Next(100);
                } while (listAngkaUji.Contains(a));
                listAngkaUji.Add(a);

                var uji = PangkatModulo(a, pangkat, prime);
                if (uji != 1 && uji != -1 && uji != prime - 1) return false;
                listHasilUji.Add(uji);
            }

            return true;
        }

        public static long RandomPrime(int minDigits, int maxDigits, int? min = null, int? max = null)
        {
            var random = new Random();
            var prime = 0L;
            long minDigit = (long)BigInteger.Pow(10, minDigits - 1);
            long maxDigit = (long)BigInteger.Pow(10, maxDigits - 1);
            do
            {
                prime = random.NextLong(minDigit, maxDigit);
            } while (!CekPrimaLehman(prime, 6) || (min != null && prime < min) || (max != null && prime >= max));

            return prime;
        }

        public static BigInteger RandomPrime(int minDigits, int maxDigits, BigInteger? min = null, BigInteger? max = null)
        {
            var random = new Random();

            BigInteger prime;

            BigInteger minInDigit = BigInteger.Pow(10, minDigits - 1);
            BigInteger maxInDigit = BigInteger.Pow(10, maxDigits - 1);

            do
            {
                prime = random.NextBigInt(minInDigit, maxInDigit);
            } while (!CekPrimaLehman(prime, 6) || (min != null && prime < min) || (max != null && prime >= max));

            return prime;
        }

        public static Bitmap Padding(Bitmap citra, int ukuranBlok = 3)
        {
            var padding = 3 - (citra.Width % ukuranBlok);

            if (padding == 3) return citra;

            var hasil = new Bitmap(citra.Width + padding, citra.Height);
            using(var g = Graphics.FromImage(hasil))
            {
                g.Clear(Color.Black);
                g.DrawImage(citra, new Point(0, 0));
            }

            return hasil;
        }

        public static string Padding(string s, int ukuranBlok = 3)
        {
            var padding =  ukuranBlok - (s.Length % ukuranBlok);

            if (padding == 3) return s;

            for (int i = 0; i < padding; i++)
                s += Encoding.UTF8.GetString(new byte[] { 0 });

            return s;
        }
    }
}
