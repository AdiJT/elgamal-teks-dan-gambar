using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal.Dekripsi.Contract
{
    public interface IDeskripsi
    {
        (long p, long x) KunciPrivat { get; set; }
    }
}
