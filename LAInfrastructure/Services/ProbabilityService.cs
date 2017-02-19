using LAInfrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using LACore.Model;
using LACore.Interfaces;
using System.Linq;

namespace LAInfrastructure.Services
{
    public class ProbabilityService : IProbabilityService
    {
        private IComputeService _computeService;
        private IRepository<Number> _numberRepository;
        private ISetDataService _setDataService;
        public ProbabilityService(IComputeService computeService, IRepository<Number> numberRepository, ISetDataService setDataService)
        {
            _computeService = computeService;
            _numberRepository = numberRepository;
            _setDataService = setDataService;
        }
        public IEnumerable<Number> GetTopNumbers(int top)
        {
            IEnumerable<Number> allNumbers = GetAllNumbers();
            return _computeService.ComputeNumbers(top, allNumbers);
        }

        private IEnumerable<Number> GetAllNumbers()
        {
            return _numberRepository.Find(n => !n.IsSpecial.GetValueOrDefault());
        }

        public void SaveStatistics()
        {
            var allNumbers = GetAllNumbers().ToList();
            _setDataService.SetMissing(allNumbers);
            _setDataService.SetOccurences(allNumbers);
            _numberRepository.Save();
        }
    }
}
