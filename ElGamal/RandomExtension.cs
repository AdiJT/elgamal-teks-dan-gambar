using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
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

        /// <summary>
        /// Returns a random BigInteger that is within a specified range.
        /// The lower bound is inclusive, and the upper bound is exclusive.
        /// </summary>
        public static BigInteger NextBigInt(this Random random,
            BigInteger minValue, BigInteger maxValue)
        {
            if (minValue > maxValue) throw new ArgumentException();
            if (minValue == maxValue) return minValue;
            BigInteger zeroBasedUpperBound = maxValue - 1 - minValue; // Inclusive
            Debug.Assert(zeroBasedUpperBound.Sign >= 0);
            byte[] bytes = zeroBasedUpperBound.ToByteArray();
            Debug.Assert(bytes.Length > 0);
            Debug.Assert((bytes[bytes.Length - 1] & 0b10000000) == 0);

            // Search for the most significant non-zero bit
            byte lastByteMask = 0b11111111;
            for (byte mask = 0b10000000; mask > 0; mask >>= 1, lastByteMask >>= 1)
            {
                if ((bytes[bytes.Length - 1] & mask) == mask) break; // We found it
            }

            while (true)
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= lastByteMask;
                var result = new BigInteger(bytes);
                Debug.Assert(result.Sign >= 0);
                if (result <= zeroBasedUpperBound) return result + minValue;
            }
        }
    }
}
