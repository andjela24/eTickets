using Microsoft.AspNetCore.Mvc;

namespace CS322_eTickets.Controllers
{
	public class MoviesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
