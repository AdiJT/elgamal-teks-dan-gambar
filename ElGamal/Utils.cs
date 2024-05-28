using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    public static class Utils
    {

        public static long PangkatModulo(long a, long n, long m)
        //a^n mod m
        {
            if (n == 0) return 1;

            if (n % 2 == 1) return Square(PangkatModulo(a, n / 2L, m)) * a % m;

            return Square(PangkatModulo(a, n / 2L, m)) % m;
        }

        public static long Square(long n)
        {
            return n * n;
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

        public static long RandomPrime(int minDigits, int maxDigits, int? min = null, int? max = null)
        {
            var random = new Random();
            var prime = 0L;

            do
            {
                prime = random.Next((int)Math.Pow(10, minDigits), (int)Math.Pow(10, maxDigits));
            } while (!CekPrimaLehman(prime, 5) || (min != null && prime < min) || (max != null && prime >= max));

            return prime;
        }
    }
}
