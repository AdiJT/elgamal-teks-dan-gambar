using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamal.Contracts
{
    public interface IEnkripsiDekripsiControl
    {
        ElGamalKey ElGamalKey { get; set; }
        bool IsValid { get; set; }
    }
}
