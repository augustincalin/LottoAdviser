using LACore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using LACore.Model;
using System.Linq;

namespace LAInfrastructure.Services
{
    public class ComputeService : IComputeService
    {
        private double _factor1 = 1d;
        private double _factor2 = 1d;
        public ComputeService(double factor1, double factor2)
        {
            _factor1 = factor1;
            _factor2 = factor2;
        }
        public IList<Number> ComputeNumbers(int top, IEnumerable<Number> numbers)
        {
            return numbers.OrderByDescending(n => _factor1 * Convert.ToDouble(n.NotSeen) * _factor2 * ( 1 / Convert.ToDouble(n.Occurencies))).Take(top).ToList();
        }
    }
}
