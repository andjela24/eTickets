using Microsoft.AspNetCore.Mvc;

namespace CS322_eTickets.Controllers
{
	public class CinemasController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
