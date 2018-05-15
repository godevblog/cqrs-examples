using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatoRExample.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatoRExample.Controllers {
    [Route("api/[controller]")]
    public class ValuesController : Controller {
        private IMediator _mediator;

        public ValuesController(IMediator mediator) {
            _mediator = mediator;
        }
        // GET api/values
        [HttpGet("{text}")]
        public async Task<string> Get(string text) {
            return await _mediator.Send(new GetDataQuery(text));
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] SetDataCommand command) {
            await _mediator.Send(command);
        }

        // DELETE api/values/5
        [HttpDelete("{key}")]
        public async void Delete(string key) { 
             await _mediator.Send(new DeleteDataCommand(key));
        }
    }
}