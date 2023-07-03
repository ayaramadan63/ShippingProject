using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingProject.Models;
using ShippingProject.Reposaitory;

namespace ShippingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private BranchesRepo _branchRepo;
        public BranchController(BranchesRepo branchRepo)
        {
            _branchRepo = branchRepo;
        }
        [HttpGet]
        public ActionResult Get_Braches()
        {
           
            return Ok(_branchRepo.GetBranches());
        }
        [HttpGet("{id}")]
        public ActionResult Get_Brach(string id)
        {
            if (id != null)
            {
                return Ok(_branchRepo.GetBranches(id));

            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult Add_Branch(Branches branch)
        {
            if (branch!=null)
            {
                _branchRepo.Insert(branch);
                return Created("", branch);
            }
            return BadRequest();
        }
        [HttpPut]
        public ActionResult update_Branch(string id)
        {
            if (id != null)
            {
                var data = _branchRepo.GetBranches(id);
                if (data != null)
                {
                    _branchRepo.Update(id, data);
                    return Created("Updated", data);
                }
            }
            return NotFound();


        }
        [HttpDelete] 
        public ActionResult Delete_Branch(string id)
        {
            if (id != null)
            {
                var data = _branchRepo.GetBranches(id);
                if (data != null)
                {
                    _branchRepo.Delete(id);
                    return Created("Deleted", data);
                }
            }
            return NotFound();
        }

    }
}
