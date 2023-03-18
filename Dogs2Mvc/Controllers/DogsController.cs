using Dogs2Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dogs2Mvc.Controllers
{
	public class DogsController : Controller
	{
		static DataService dataService=new DataService();
		[HttpGet("")]
		public IActionResult Index()
		{
			Dog[] model = dataService.GetAll();
			return View(model);
		}
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(Dog dog)
        {
            if(!ModelState.IsValid) 
            return View();
            dataService.AddDog(dog);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("Update/{id}")]
        public IActionResult Update(int id, Dog dog)
        {
            dataService.Update(id, dog);
            return RedirectToAction(nameof(Index));
        }
		[HttpGet("Update/{id}")]
		public IActionResult Update(int id)
		{
			var model = dataService.FindById(id);
			return View(model);
		}
		[HttpGet("Delete")]
		public IActionResult Delete(int id)
		{
			var model = dataService.FindById(id);
			return View(model);
		}
		[HttpPost("Update/{id}")]
		public IActionResult Delete(int id,Dog dog)
		{
			var model = dataService.FindById(id);
			return View(model);
		}
	}
}
