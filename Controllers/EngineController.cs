using Microsoft.AspNetCore.Mvc;

namespace CarEngines.Controllers
{
    public class EngineController : Controller
    {
        private readonly IMainRepository<Engine> _engineRepository;             

        public EngineController(IMainRepository<Engine> engineRepository)
        {
            _engineRepository = engineRepository;
        }

        public IActionResult Index()
        {
            var enginesList = _engineRepository.GetFullList();
            return View(enginesList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Engine engine)
        {
            var engines = _engineRepository.GetFullList();
            if (!ModelState.IsValid) return BadRequest();           
            engines.Add(engine);
            _engineRepository.Save();
            return RedirectToAction("Index");                               
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return BadRequest();
            var engineInDb = _engineRepository.FindByID(id);
            if(engineInDb == null) return BadRequest();           
            return View(engineInDb);
        }

        [HttpPost]
        public IActionResult Edit(Engine engine)
        {            
            if (!ModelState.IsValid) return BadRequest();

            _engineRepository.UpdateElement(engine);
            _engineRepository.Save();
            return RedirectToAction("Index");
            
        }

       
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            var engineInDb = _engineRepository.FindByID(id);
            if (engineInDb == null) return BadRequest();
            _engineRepository.DeleteElement(engineInDb);
            _engineRepository.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {            
            return RedirectToAction("Index", "Car", new { id = id });        
        }
    }
}
