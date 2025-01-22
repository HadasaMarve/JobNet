using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly IMapper _mapper;

        public SubscriptionsController(ISubscriptionService subscriptionService, IMapper mapper)
        {
            _subscriptionService = subscriptionService;
            _mapper = mapper;
        }
        // GET: api/<JobsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var subscription = await _subscriptionService.GetAllAsync();
            var subscriptionsDto = _mapper.Map<IEnumerable<SubscriptionDto>>(subscription);
            return Ok(subscriptionsDto);
        }

        // GET api/<JobsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var subscription = _subscriptionService.Get(id);
            if (subscription == null)
            {
                return NotFound();
            }
            var subscriptionDto = _mapper.Map<SubscriptionDto>(subscription);
            return Ok(subscriptionDto);
        }

        // POST api/<JobsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SubscriptionPostModel value)
        {
                //var subscription = new Subscription { SubscriberID = value.SubscriberID, UserId = value.UserId, SubscriptionDate = value.SubscriptionDate};
                var subscription=_mapper.Map<Subscription>(value);
                var s=await _subscriptionService.AddAsync(subscription);
                return Ok(s);
        }

        // PUT api/<JobsController>/5
        //[HttpPut("{id}")]
        //public Subscription Put(int id, [FromBody] Subscription value)
        //{
        //    int index = _subscriptionService.GetList().FindIndex(x => x.SubscriberID == id);
        //    _subscriptionService.GetList()[index].SubscriberID = value.SubscriberID;
        //    _subscriptionService.GetList()[index].UserId = value.UserId;
        //    _subscriptionService.GetList()[index].SubscriptionDate = value.SubscriptionDate;
        //    return _subscriptionService.GetList()[index];
        //}

        // DELETE api/<JobsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var subscription = await _subscriptionService.DeleteAsync(id);
            return Ok(subscription);
        }
    }
}
