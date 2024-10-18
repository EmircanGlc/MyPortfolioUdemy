using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ExperienceList()
        {
            
            var values = context.Experiences.ToList(); 
            return View(values);
        }
        //Yeni deneyim girişi yapmak için burayı kullanacağız.
        [HttpGet] //Sayfa ilk yüklendiğinde açılacak.
        public IActionResult CreateExperience()
        {
                return View();
        }
        [HttpPost] //Sayfada bir butona tıklandığında çalışacak.
        public IActionResult CreateExperience(Experience experience) 
        {
			context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id) //Silme işlemi Id'ye göre yapılacak.
        {
            var value = context.Experiences.Find(id); //Silinecek veriyi bulduk. s.değer = value 
            context.Experiences.Remove(value); //Valuedan gelen değeri sil.
            context.SaveChanges(); //Kaydet
			return RedirectToAction("ExperienceList"); //Bizi tekrar ExperienceListe yönlendir.
		}
        [HttpGet]
        public IActionResult UpdateExperience(int id) 
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

            
        }
	}
}
