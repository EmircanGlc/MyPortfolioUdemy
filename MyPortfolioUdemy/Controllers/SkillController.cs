using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult SkillList()
		{
			var values = context.Skills.ToList();
			return View(values);
		}
		//Yeni Yetenek girişi yapmak için burayı kullanacağız.
		[HttpGet] //Sayfa ilk yüklendiğinde açılacak.
		public IActionResult CreateSkill()
		{
			return View();
		}
        [HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("SkillList");
		}
		public IActionResult DeleteSkill(int id) //Silme işlemi Id'ye göre yapılacak.
		{
			var value = context.Skills.Find(id); //Silinecek veriyi bulduk. s.değer = value 
			context.Skills.Remove(value); //Valuedan gelen değeri sil.
			context.SaveChanges(); //Kaydet
			return RedirectToAction("SkillList"); 
		}

	}
}
