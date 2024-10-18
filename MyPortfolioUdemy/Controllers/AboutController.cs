using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult AboutText()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}
	}
}
