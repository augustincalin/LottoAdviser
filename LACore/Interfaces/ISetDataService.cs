using LACore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LACore.Interfaces
{
    public interface ISetDataService
    {
        void SetOccurences(IList<Number> numbers);
        void SetMissing(IList<Number> numbers);
    }
}
