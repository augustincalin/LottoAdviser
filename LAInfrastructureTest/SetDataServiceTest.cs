using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAInfrastructure.Services;
using LACore.Model;
using System.Collections.Generic;
using System.Linq;

namespace LAInfrastructureTest
{
    [TestClass]
    public class SetDataServiceTest
    {
        [TestMethod]
        public void SetMissing_Should_Set_Missing_Info()
        {
            SetDataServiceOptions options = new SetDataServiceOptions {
                MissingUrl = "https://www.lotto-hessen.de/pfe/controller/DrawingStatisticsController/showLottoTrends?gbn=5&loc=de&jdn=5",
                MissingRegex= @"<span>(\d+)</span></div>.+?<span class=""amount.+?""> (.+?) </span>",
                OccurenciesRegex= @"<span>(\d+)</span></div>.+?<span class=""amount"">(\d+) x</span>",
                OccurenciesUrl= "https://www.lotto-hessen.de/pfe/controller/DrawingStatisticsController/showLottoGameCycles?gbn=5&loc=de&jdn=5 "
            };
            SetDataService testee = new SetDataService(options);
            List<Number> numbers = new List<Number>();
            for(int i = 1; i < 50; i++)
            {
                numbers.Add(new Number { Id = i, IsSpecial = false, NotSeen = null, Number1 = i, Occurencies = null });
            }
            testee.SetMissing(numbers);

            int lastExtracted = numbers.Where(n => n.NotSeen == 0).Count();
            
            Assert.AreEqual(lastExtracted, 6);
        }
        [TestMethod]
        public void SetMissing_Should_Set_Occurencies_Info()
        {
            SetDataServiceOptions options = new SetDataServiceOptions
            {
                MissingUrl = "https://www.lotto-hessen.de/pfe/controller/DrawingStatisticsController/showLottoTrends?gbn=5&loc=de&jdn=5",
                MissingRegex = @"<span>(\d+)</span></div>.+?<span class=""amount.+?""> (.+?) </span>",
                OccurenciesRegex = @"<span>(\d+)</span></div>.+?<span class=""amount"">(\d+) x</span>",
                OccurenciesUrl = "https://www.lotto-hessen.de/pfe/controller/DrawingStatisticsController/showLottoGameCycles?gbn=5&loc=de&jdn=5 "
            };
            SetDataService testee = new SetDataService(options);
            List<Number> numbers = new List<Number>();
            for (int i = 1; i < 50; i++)
            {
                numbers.Add(new Number { Id = i, IsSpecial = false, NotSeen = null, Number1 = i, Occurencies = null });
            }
            testee.SetOccurences(numbers);

            int nullNumbers = numbers.Where(n => n.Occurencies == null).Count();

            Assert.AreEqual(nullNumbers, 0);
        }
    }
}
