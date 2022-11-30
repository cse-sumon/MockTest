using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interface;
using ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepo _subjectRepo;
        public SubjectController(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }

        // GET: api/<Subject>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_subjectRepo.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<Subject>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if(id < 1)
                {
                    return BadRequest();
                }
                var result = _subjectRepo.Get(id);
                if(result != null)
                {
                    return Ok(result);
                }
                return NotFound();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<Subject>
        [HttpPost]
        public IActionResult Post(SubjectViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                    return BadRequest();

                _subjectRepo.Insert(model);
                return Ok(new ResponseModel { Status = "Success", Message = "Subject Created successfully!" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<Subject>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, SubjectViewModel model)
        {
            try
            {
                if (id != model.Id || !ModelState.IsValid)
                    return BadRequest(model);

                _subjectRepo.Update(model);
                return Ok(new ResponseModel { Status = "Success", Message = "subject Updated successfully!" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<Subject>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id < 1)
                    return BadRequest();

                var result = _subjectRepo.Get(id);
                if (result == null)
                    return NotFound();

                _subjectRepo.Delete(result);
                return Ok(new ResponseModel { Status = "Success", Message = "Subject Deleted successfully!" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
