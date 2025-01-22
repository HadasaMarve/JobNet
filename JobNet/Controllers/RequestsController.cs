using AutoMapper;
using JobNet.Models;
using JobNet.Core.DTOs;
using JobNet.Core.Entities;
using JobNet.Core.Services;
using Microsoft.AspNetCore.Mvc;
using JobNet.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {

        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;

        public RequestsController(IRequestService requestService, IMapper mapper)
        {
            _requestService = requestService;
            _mapper = mapper;
        }

        // GET: api/<RequestsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var requests = await _requestService.GetAllAsync();
            var requestsDto = _mapper.Map<IEnumerable<RequestDto>>(requests);
            return Ok(requestsDto);
        }

        // GET api/<RequestsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var request = _requestService.Get(id);
            if (request == null)
            {
                return NotFound();
            }
            var requestDto = _mapper.Map<RequestDto>(request);
            return Ok(requestDto);
        }

        // POST api/<RequestsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RequestPostModel value)
        {
                //var request = new Request { RequestID = value.RequestID, JobID = value.JobID, UserID = value.UserID, Message = value.Message, RequestDate = value.RequestDate };
                var request=_mapper.Map<Request>(value);
                var r=await _requestService.AddAsync(request);    
                return Ok(r);
        }

        // PUT api/<RequestsController>/5
        //[HttpPut("{id}")]
        //public Request Put(int id, [FromBody] Request value)
        //{
        //    int index= _requestService.GetList().FindIndex(x => x.RequestID == id);
        //    _requestService.GetList()[index].RequestID = value.RequestID;
        //    _requestService.GetList()[index].JobID = value.JobID;
        //    _requestService.GetList()[index].UserID = value.UserID;
        //    _requestService.GetList()[index].Message = value.Message;
        //    _requestService.GetList()[index].RequestDate = value.RequestDate;
        //    return _requestService.GetList()[index];
        //}

        // DELETE api/<RequestsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var request = await _requestService.DeleteAsync(id);
            return Ok(request);
        }
    }
}
