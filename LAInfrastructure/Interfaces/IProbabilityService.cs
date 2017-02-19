using LACore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAInfrastructure.Interfaces
{
    public interface IProbabilityService
    {
        IEnumerable<Number> GetTopNumbers(int top);
        void SaveStatistics();
    }
}
