using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Verify()
        {
            return View();
        }


        public IActionResult Approve(Guid id)
        {
            return RedirectToAction("Verify");
        }
    }
}
