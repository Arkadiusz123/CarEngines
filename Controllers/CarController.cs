using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarEngines.Controllers
{
    public class CarController : Controller
    {
        private readonly IMainRepository<Car> _carRepository;
        private readonly IMainRepository<Engine> _engineRepository;


        private Engine EngineModel { get; set; }

        public CarController(IMainRepository<Car> carRepository, IMainRepository<Engine> engineRepository)
        {
            _carRepository = carRepository;
            _engineRepository = engineRepository;
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                var engine = _engineRepository.FindByID(id);
                var carsWithThisEngine = _carRepository.GetFullList().Where(e => e.Engine == engine);

                ViewBag.message = $"Cars with engine {engine.Brand}, capacity: {engine.Capacity_ccm} ccm";

                return View(carsWithThisEngine);
            }
            else
            {
                var allCarsInDb = _carRepository.GetFullList();
                ViewBag.message = "List of all cars";
                return View(allCarsInDb);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            var enginesList = _engineRepository.GetFullList();

            ViewBag.data = enginesList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (!ModelState.IsValid) return BadRequest();
            _carRepository.AddElement(car);
            _carRepository.Save();

            return RedirectToAction("Index", new { id = car.EngineId });
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return BadRequest();
            var carInDb = _carRepository.FindByID(id);
            if (carInDb == null) return BadRequest();

            var enginesList = _engineRepository.GetFullList();
            ViewBag.data = enginesList;

            return View(carInDb);
        }

        [HttpPost]
        public IActionResult Edit(Car car)
        {          
            if (!ModelState.IsValid) return BadRequest();
            _carRepository.UpdateElement(car);
            _carRepository.Save();

            return RedirectToAction("Index", new { id = car.EngineId });
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            var carInDb = _carRepository.FindByID(id);
            if (carInDb == null) return BadRequest();
            _carRepository.DeleteElement(carInDb);
            _carRepository.Save();

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
