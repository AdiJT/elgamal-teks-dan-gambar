using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal.Enkripsi.Contract
{
    public interface IEnkripsi
    {
        (long p, long g, long y) KunciPublik { get; set; }
    }
}
