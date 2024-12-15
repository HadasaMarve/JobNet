using AutoMapper;
using JobNet.Core.DTOs;
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
        private readonly IMapper _mapper;

        public EmployersController(IEmployerService employerService, IMapper mapper)
        {
            _employerService = employerService;
            _mapper = mapper;
        }


        // GET: api/<EmployersController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var employers = await _employerService.GetAllAsync();
            var employersDto = _mapper.Map<IEnumerable<EmployerDto>>(employers.Result);
            return Ok(employersDto);
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
            var employerDto = _mapper.Map<EmployerDto>(employer);
            return Ok(employerDto);
        }

        // POST api/<EmployersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Employer value)
        {
            //var employer = _employerService.Get(value.EmployerID);
            //if (employer == null)
            //{
                var employer = new Employer { EmployerID = value.EmployerID, CompanyName = value.CompanyName, Industry = value.Industry, UserID=value.UserID };
                var e=await _employerService.AddAsync(employer);
                return Ok(_employerService.Add(employer));
            //}
            //return Conflict();
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
