using Microsoft.AspNetCore.Mvc;

namespace InsurancePremiumCalculator.Controllers
{
    public class PremiumController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Occupations = new List<string>
            {
                "Cleaner", "Doctor", "Author", "Farmer", "Mechanic", "Florist", "Other"
            };

            return View();
        }
    }
}
