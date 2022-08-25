using appointmentMaker.Models;
using Microsoft.AspNetCore.Mvc;

namespace appointmentMaker.Controllers
{
    public class appointmentController : Controller
    {
        static List<appointmentModel> appointments = new List<appointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult create()
        {
            return View();
        }
        public IActionResult showDetails(appointmentModel appointmentDetail)
        {
            appointments.Add(appointmentDetail);
            return View("showDetails", appointmentDetail);
        }
    }
}
