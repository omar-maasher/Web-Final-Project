using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using weppro.Models;
namespace weppro.Controllers
{
    public class PedometerController : Controller
    {
        private Contxt _Contxt;
        public PedometerController (Contxt contxt)
        {
            _Contxt = contxt; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }
         [HttpPost]
        public IActionResult StepsToCalories(infos NumOfSteps)
        {
            NumOfSteps.Date = DateTime.Now;
            double TotalCaloriesBurned = NumOfSteps.Steps * 0.04;

            _Contxt.Infostep1.Add(NumOfSteps);
            _Contxt.SaveChanges();

             return View(TotalCaloriesBurned);

        }

    }
}
