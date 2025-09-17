using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            var sample = new List<Claim>
            {
                new Claim { ClaimId = Guid.NewGuid(), Month = "August", Year = 2025, HoursWorked = 20, HourlyRate = 300, Status = ClaimStatus.Submitted },
                new Claim { ClaimId = Guid.NewGuid(), Month = "July", Year = 2025, HoursWorked = 18, HourlyRate = 300, Status = ClaimStatus.Approved }
            };
            return View(sample);
        }

        public IActionResult Submit()
        {
            return View();
        }

        public IActionResult Details(Guid id)
        {
            var demo = new Claim { ClaimId = id == Guid.Empty ? Guid.NewGuid() : id, Month = "August", Year = 2025, HoursWorked = 20, HourlyRate = 300, Status = ClaimStatus.Submitted };
            return View(demo);
        }


        public IActionResult Track(Guid id)
        {
            var demo = new Claim { ClaimId = id == Guid.Empty ? Guid.NewGuid() : id, Month = "August", Year = 2025, HoursWorked = 20, HourlyRate = 300, Status = ClaimStatus.Verified };
            return View(demo);
        }
    }
}
