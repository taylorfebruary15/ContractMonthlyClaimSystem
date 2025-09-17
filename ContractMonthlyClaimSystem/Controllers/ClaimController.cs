using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Submit() => View(); 
        [HttpPost]
        public IActionResult Submit(object model)
        {
            TempData["Success"] = "(Prototype) Claim submission will be processed.";
            return RedirectToAction("Submit");
        }


        public IActionResult List() => View();
    }
}
