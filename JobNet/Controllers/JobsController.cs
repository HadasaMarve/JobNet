using JobNet.Core.Entities;
using JobNet.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }


        // GET: api/<JobsController>
        [HttpGet]
        public ActionResult Get()
        {
            
                return Ok(_jobService.GetList());
        }

            // GET api/<JobsController>/5
            [HttpGet("{id}")]
            public ActionResult Get(int id)
            {
            var job = _jobService.Get(id);
            if (job == null)
            {
                return NotFound();
            }
            return Ok(job);
        }

            // POST api/<JobsController>
            [HttpPost]
            public ActionResult Post([FromBody] Job value)
            {
                var job = _jobService.Get(value.JobID);
                if (job == null)
                {
                    return Ok(_jobService.Add(value));
                }
                return Conflict();
            }

            // PUT api/<JobsController>/5
            //[HttpPut("{id}")]
            //public Job Put(int id, [FromBody] Job value)
            //{
            //    int index = _jobService.GetList().FindIndex(x => x.JobID == id);
            //    _jobService.GetList()[index].JobID = value.JobID;
            //    _jobService.GetList()[index].EmployerID = value.EmployerID;
            //    _jobService.GetList()[index].Title = value.Title;
            //    _jobService.GetList()[index].Description = value.Description;
            //    _jobService.GetList()[index].Location = value.Location;
            //    _jobService.GetList()[index].Salary = value.Salary;
            //    _jobService.GetList()[index].PostedDate = value.PostedDate;
            //    return _jobService.GetList()[index];
            //}

            //// DELETE api/<JobsController>/5
            //[HttpDelete("{id}")]
            //public void Delete(int id)
            //{
            //    var index = _jobService.GetList().FindIndex(e => e.JobID == id);
            //    _jobService.GetList().Remove(_jobService.GetList()[index]);
            //}
    }
}