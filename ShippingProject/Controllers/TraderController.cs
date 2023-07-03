using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingProject.DTO;
using ShippingProject.Models;
using ShippingProject.Reposaitory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShippingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraderController : ControllerBase
    {
        public readonly ITraderRepository _traderRepository;

        public TraderController(ITraderRepository traderRepository)
        {
            _traderRepository = traderRepository;
        }

        [HttpGet]
        public  ActionResult GetAll()
        {
           return Ok( _traderRepository.GetAll());
        }

        [HttpGet("id")]
        public ActionResult GetById(string id)
        {
            var res = _traderRepository.GetById(id);
       
            return Ok(res);
        }
        [HttpPost]

        public ActionResult Add(TraderViewModel trader)
        {
            if (trader != null)
            {
                Trader trade = new Trader()
                {
                    Address = trader.Address,
                    Email = trader.Email,
                    Id_Branch   = trader.Id_Branch,
                    Id_City = trader.Id_City,
                    Name = trader.Name,
                    Password = trader.Password,
                    Per_Rejected_order = trader.Per_Rejected_order,
                    Phone = trader.Phone,
                    Id_Governate = trader.Id_Governate,
                    IsDeleted = false,
                    ID = Guid.NewGuid().ToString()
                };
                _traderRepository.Add(trade);
                return Created("", trader);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult Update(string id, UpdateTraderViewModel model)
        {
            if (id != null)
            {
                var trader = _traderRepository.GetById(id);
                if (trader != null)
                {
                    trader.Per_Rejected_order = model.Per_Rejected_order ?? trader.Per_Rejected_order;
                    trader.Address = model.Address ?? trader.Address;
                    trader.Email = model.Email ?? trader.Email;
                    trader.Id_City = model.Id_City ?? trader.Id_City;
                    trader.Name = model.Name ?? trader.Name;
                    trader.Password = model.Password ?? trader.Password;
                    trader.Phone = model.Phone ?? trader.Phone;
                    trader.Id_Branch = model.Id_Branch ?? trader.Id_Branch;
                    trader.Id_Governate = model.Id_Governate ?? trader.Id_Governate;
                    trader.IsDeleted = false;
                    _traderRepository.Update(id, trader); // use the id parameter here
                    return Created("Updated", trader);
                }
            }
            return NotFound();
        

        //  var traderbyid = _traderRepository.GetById(trader.Id);



        //traderbyid.Address = trader.Address;
        //traderbyid.Email= trader.Email;
        //traderbyid.Per_Rejected_order= trader.Per_Rejected_order;
        //traderbyid.Id_Branch= trader.Id_Branch;
        //traderbyid.Id_Governate= trader.Id_Governate;
        //traderbyid.Id_City= trader.Id_City;
        //traderbyid.Password = trader.Password;
        //traderbyid.Phone = trader.Phone;

        //_traderRepository.Update(new UpdateTraderViewModel()
        //{
        //    //Address = traderbyid.Address,
        //    //Email = traderbyid.Email,
        //    //Id_Branch = traderbyid.Id_Branch,
        //    //Id_City = traderbyid.Id_City,
        //    //Name = traderbyid.Name,
        //    //Password = traderbyid.Password,
        //    //Per_Rejected_order = traderbyid.Per_Rejected_order,
        //    //Phone = traderbyid.Phone,
        //    //Id_Governate = traderbyid.Id_Governate,

        //});
        // _traderRepository.Update(trader);
        //  return Created("Updated", trader);

        //return NoContent();

    }
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var traderbyid = _traderRepository.GetById(id);
            if (traderbyid != null)
            {
                traderbyid.IsDeleted = true;
                _traderRepository.Update(id,traderbyid); 
               _traderRepository.Save();// set IsDeleted property to true
                return Ok(traderbyid); // return the updated entity
            }

            return NotFound();
        }



    }
}
