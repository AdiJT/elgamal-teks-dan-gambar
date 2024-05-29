using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal
{
    public static class RandomExtension
    {
        public static long NextLong(this Random random, long min = 0, long max = long.MaxValue)
        {
            if (max <= min) throw new ArgumentOutOfRangeException("max", "max must > min");

            ulong uRange = (ulong)(max - min);

            ulong uRand;
            do
            {
                byte[] buf = new byte[8];
                random.NextBytes(buf);
                uRand = (ulong)BitConverter.ToInt64(buf, 0);
            } while (uRand > ulong.MaxValue - ((ulong.MaxValue % uRange) + 1) % uRange);

            return (long)(uRand % uRange) + min;
        }
    }
}
