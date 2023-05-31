using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RazorBite.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult MainPage()
		{
			return View();
		}

		[Authorize]
		public IActionResult Rezervation()
		{
			return View();
		}

		public IActionResult Menu()
		{
			return View();
		}

		[Authorize]
		public IActionResult Blog()
		{
			return View();
		}
	}
}
