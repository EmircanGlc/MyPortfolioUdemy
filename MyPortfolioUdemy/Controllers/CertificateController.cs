using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class CertificateController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult CertificateList()
        {
            var values = context.Certificates.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCertificate(Certificate certificate)
        {
            context.Certificates.Add(certificate);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
		public IActionResult DeleteCertificate(int id)
		{
			var value = context.Certificates.Find(id);
			context.Certificates.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
