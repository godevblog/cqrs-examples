using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomExample.Bus.Command;
using CustomExample.Bus.Query;
using Microsoft.AspNetCore.Mvc;

namespace CustomExample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller {
        private IQueryBus _queryBus;
        private ICommandBus _commandBus;

        public ValuesController(IQueryBus queryBus, ICommandBus commandBus) {
            _queryBus = queryBus;
            _commandBus = commandBus;
        }
        // GET api/values
        [HttpGet("{text}")]
        public async Task<string> Get(string text) {
            return await _queryBus.Process(new GetDataQuery(text));
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] SetDataCommand command) {
            await _commandBus.SendCommand(command);
        }

        // DELETE api/values/5
        [HttpDelete("{key}")]
        public async void Delete(string key) { 
             await _commandBus.SendCommand(new DeleteDataCommand(key));
        }
    }
}