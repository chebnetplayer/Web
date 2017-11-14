using Microsoft.AspNetCore.Mvc;
using proj.Models;

namespace proj.Controllers
{
    [Produces("application/json")]
    [Route("car")]
    public class CarController : Controller
    {
        public Carmanager Carmanager;

        public CarController()
        {
            Carmanager = CarManagerSingleTone.Carmanager;
        }
        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetCarById(int id)
        {
            return Ok(Carmanager.GetCarById(id));
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddCar([FromBody] Car car)
        {
            Carmanager.Add(car);
            return Ok(Carmanager.count);
        }
        [HttpPut]
        [Route("change/{id}")]
        public IActionResult AddCar(int id, [FromBody] int price)
        {
            Carmanager.ChangePrice(id, price);
            return Ok(Carmanager.GetCarById(id).Price);
        }

    }
}