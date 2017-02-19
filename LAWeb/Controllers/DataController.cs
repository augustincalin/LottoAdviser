using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LAInfrastructure.Interfaces;

namespace LAWeb.Controllers
{
    public class DataController : Controller
    {
        private IProbabilityService _probabilityService;
        public DataController(IProbabilityService probabilityService)
        {
            _probabilityService = probabilityService;
        }
        [Route("/api/data/fetch")]
        public void SaveData()
        {
            _probabilityService.SaveStatistics();
        }


    }
}
