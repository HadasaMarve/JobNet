using JobNet.Core.Entities;
using JobNet.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionsController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }
        // GET: api/<JobsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_subscriptionService.GetList());
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
            return Ok(subscription);
        }

        // POST api/<JobsController>
        [HttpPost]
        public ActionResult Post([FromBody] Subscription value)
        {
            var subscription = _subscriptionService.Get(value.SubscriberID);
            if (subscription == null)
            {
                return Ok(_subscriptionService.Add(value));
            }
            return Conflict();
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
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var index = _subscriptionService.GetList().FindIndex(e => e.SubscriberID == id);
        //    _subscriptionService.GetList().Remove(_subscriptionService.GetList()[index]);
        //}
    }
}
