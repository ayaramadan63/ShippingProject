using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingProject.Models;
using ShippingProject.Reposaitory;

namespace ShippingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesReposaitory _citiesReposaitory;
        public CitiesController(CitiesReposaitory citiesReposaitory)
        {
            _citiesReposaitory = citiesReposaitory;
        }
        [HttpGet]
        public ActionResult Get_Cities()
        {
            return Ok(_citiesReposaitory.GetCities());
        }
        [HttpGet("{id}")]
        public ActionResult Get_city(string id)
        {
            if (id != null)
            {
                return Ok(_citiesReposaitory.GetCities(id));

            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult Add_City(Cities city)
        {
            if (city != null)
            {
                _citiesReposaitory.Insert(city);
                return Created("", city);
            }
            return BadRequest();
        }
        [HttpPut]
        public ActionResult update_City(string id)
        {
            if (id != null)
            {
                var data = _citiesReposaitory.GetCities(id);
                if (data != null)
                {
                    _citiesReposaitory.Update(id, data);
                    return Created("Updated", data);
                }
            }
            return NotFound();


        }
        [HttpDelete]
        public ActionResult Delete_City(string id)
        {
            if (id != null)
            {
                var data = _citiesReposaitory.GetCities(id);
                if (data != null)
                {
                    _citiesReposaitory.Delete(id);
                    return Created("Deleted", data);
                }
            }
            return NotFound();
        }
    }
}
