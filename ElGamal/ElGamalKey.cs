using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    public class ElGamalKey
    {
        public ElGamalKey(int digitKunci, BigInteger minimalKunci) 
        {
            DigitKunci = digitKunci;
            MinimalKunci = minimalKunci;
            GenerateKey();
        }

        public int DigitKunci { get; set; }
        public BigInteger MinimalKunci { get; set; }

        public BigInteger P { get; set; }
        public BigInteger G { get; set; }
        public BigInteger Y { get; set; }
        public BigInteger X { get; set; }

        public (BigInteger P, BigInteger G, BigInteger Y) KunciPublik { get => (P, G, Y); }
        public (BigInteger P, BigInteger X) KunciPrivat { get => (P, X); }

        public void GenerateKey()
        {
            Random random = new Random();

            var p = Utils.RandomPrime(DigitKunci, DigitKunci + 1, MinimalKunci);

            var g = random.NextBigInt(1, p);
            var x = random.NextBigInt(1, p - 1);

            var y = Utils.PangkatModulo(g, x, p);

            P = p;
            G = g;
            Y = y;
            X = x;
        }
    }
}
