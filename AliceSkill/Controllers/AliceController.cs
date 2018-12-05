using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceExchangeProtocol;
using AlisaExchangeProtocol;
using AlisaExchangeProtocol.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PizzaOrderService;
using Stateless;

namespace AlisaSkill.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AliceController 
        : ControllerBase
    {
        private IMemoryCache _cache;

        private IPizzaOrderService _service;

        public AliceController(IPizzaOrderService service, IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            _service = service;
        }

        [HttpPost("/alice")]
        public AliceResponse WebHook([FromBody] AliceRequest req)
        {
            var machine = GetAliceStateMachine(req.session.session_id);
            return machine.FireNext(req);
        }
        /// <summary>
        /// Вернуть State machine
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        private AliceStateMachine GetAliceStateMachine(string sessionId)
        {
            if(_cache.TryGetValue(sessionId, out AliceStateMachine machine))
            {
                return machine;
            }
            else
            {
                AliceStateMachine newMachine = new AliceStateMachine(_service);
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep in cache for this time, reset time if accessed.
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                _cache.Set(sessionId, newMachine, cacheEntryOptions);
                return newMachine;
            }
        }
    }
}
