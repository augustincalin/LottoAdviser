using LACore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LACore.Interfaces
{
    public interface IComputeService
    {
        IList<Number> ComputeNumbers(int top, IEnumerable<Number> numbers);
    }
}
