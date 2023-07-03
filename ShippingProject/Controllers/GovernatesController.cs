using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingProject.Models;
using ShippingProject.Reposaitory;

namespace ShippingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernatesController : ControllerBase
    {
        private readonly GovernatesReposaitory _governatesReposaitory;
        public GovernatesController(GovernatesReposaitory governatesReposaitory)
        {
            _governatesReposaitory = governatesReposaitory;
        }
        [HttpGet]
        public ActionResult Get_governate()
        {
            return Ok(_governatesReposaitory.GetGovernates());
        }
        [HttpGet("{id}")]
        public ActionResult Get_governates(string id)
        {
            if (id != null)
            {
                return Ok(_governatesReposaitory.GetGovernates(id));

            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult Add_Governate(Governates governates)
        {
            if (governates != null)
            {
                _governatesReposaitory.Insert(governates);
                return Created("", governates);
            }
            return BadRequest();
        }
        [HttpPut]
        public ActionResult update_Governate(string id)
        {
            if (id != null)
            {
                var data = _governatesReposaitory.GetGovernates(id);
                if (data != null)
                {
                    _governatesReposaitory.Update(id, data);
                    return Created("Updated", data);
                }
            }
            return NotFound();


        }
        [HttpDelete]
        public ActionResult Delete_Governate(string id)
        {
            if (id != null)
            {
                var data = _governatesReposaitory.GetGovernates(id);
                if (data != null)
                {
                    _governatesReposaitory.Delete(id);
                    return Created("Deleted", data);
                }
            }
            return NotFound();
        }
    }
}
