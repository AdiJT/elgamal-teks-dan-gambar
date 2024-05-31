using ElGamal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TesPangkatModulo();
            Console.WriteLine();
            CekPrima();
            Console.WriteLine();
            TesPrimaAcak();
            Console.WriteLine();
            TesGenerateKunciCitra();

            Console.ReadKey();
        }   

        static void TesGenerateKunciCitra()
        {
            var minimal = BigInteger.Parse("255255255255255255255255255");
            var digits = 27;
            var elGamal = new ElGamalKey(digits, minimal);

            elGamal.GenerateKey();

            Console.WriteLine($"P : {elGamal.P}");
            Console.WriteLine($"G : {elGamal.G}");
            Console.WriteLine($"Y : {elGamal.Y}");
            Console.WriteLine($"X : {elGamal.X}");
        }

        static void TesPangkatModulo()
        {
            BigInteger a = new BigInteger(1.5674556586e36);
            BigInteger n = new BigInteger(4.566e18); ;
            BigInteger m = new BigInteger(2.567e18); ;

            BigInteger hasil = 0;

            var lama = TesWaktu(() => hasil = Utils.PangkatModulo(a, n, m));
            Console.WriteLine($"{a}^{n} mod {m} : {hasil}");
            Console.WriteLine($"Lama Pengerjaan: {lama} ms");
        }

        static void CekPrima()
        {
            var prima = 7141417L;
            var bukanPrima = 7572757L;
            var banyakUji = 6;

            var hasil = false;

            var lama = TesWaktu(() => hasil = Utils.CekPrimaLehman(prima, banyakUji));
            if(hasil == true)
                Console.WriteLine($"{prima} adalah prima dengan kesalahan {1/Math.Pow(2, banyakUji):F6}%");
            else
                Console.WriteLine($"{prima} bukan prima");
            Console.WriteLine($"Lama Pengerjaan: {lama} ms");

            Console.WriteLine();
            lama = TesWaktu(() => hasil = Utils.CekPrimaLehman(bukanPrima, banyakUji));
            if (hasil == true)
                Console.WriteLine($"{bukanPrima} adalah prima dengan kesalahan {1 / Math.Pow(2, banyakUji):F6}%");
            else
                Console.WriteLine($"{bukanPrima} bukan prima");
            Console.WriteLine($"Lama Pengerjaan: {lama} ms");
        }

        static void TesPrimaAcak()
        {
            BigInteger prima = 0;

            var lama = TesWaktu(() => prima = Utils.RandomPrime(18, 19, BigInteger.Parse("255255255255255255")));

            Console.WriteLine($"Bilangan prima acak : {prima}");
            Console.WriteLine($"Lama Pengerjaan: {lama} ms");
        }

        static long TesWaktu(Action action)
        {
            var timer = new Stopwatch();
            timer.Start();
            action();
            timer.Stop();
            return timer.ElapsedMilliseconds;
        }
    }
}
