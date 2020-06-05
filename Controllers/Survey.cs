using System.Collections.Generic;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class Survey : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("survey");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult PostSurvey(SurvMod Surv)
        {
            SurvMod YourSurvey = Surv;

            return View("results", Surv);
        }
    }
}