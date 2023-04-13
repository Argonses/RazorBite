using Microsoft.AspNetCore.Mvc;

namespace RazorBite.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult MainPage()
		{
			return View();
		}
	}
}
