using JobNet.Core.Entities;
using JobNet.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        private readonly IEmployerService _employerService;

        public EmployersController(IEmployerService employerService)
        {
            _employerService = employerService;
        }


        // GET: api/<EmployersController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_employerService.GetList());
        }

        // GET api/<EmployersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employer = _employerService.Get(id);
            if (employer == null)
            {
                return NotFound();
            }
            return Ok(employer);
        }

        // POST api/<EmployersController>
        [HttpPost]
        public ActionResult Post([FromBody] Employer value)
        {
            var employer = _employerService.Get(value.EmployerID);
            if (employer == null)
            {
                return Ok(_employerService.Add(value));
            }
            return Conflict();
        }

        // PUT api/<EmployersController>/5
        //[HttpPut("{id}")]
        //public Employer Put(int id, [FromBody] Employer value)
        //{
        //    int index = _employerService.GetList().FindIndex(x => x.EmployerID == id);
        //    _employerService.GetList()[index].UserID = value.UserID;
        //    _employerService.GetList()[index].CompanyName = value.CompanyName;
        //    _employerService.GetList()[index].Industry = value.Industry;
        //    return _employerService.GetList()[index];

        //}

        // DELETE api/<EmployersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    int index = _employerService.GetList().FindIndex(x => x.EmployerID == id);
        //    _employerService.GetList().RemoveAt(index);
        //}
    }
}
