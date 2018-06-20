using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EventFlow;
using EventFlow.Queries;
using EventFlowExample.Commands;
using EventFlowExample.Models;
using EventFlowExample.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EventFlowExample.Controllers {
    [Route("api/[controller]")]
    public class ValuesController : Controller {
        private IQueryProcessor _queryProcessor;
        private ICommandBus _commandBus;

        public ValuesController(IQueryProcessor queryProcessor, ICommandBus commandBus) {
            _queryProcessor = queryProcessor;
            _commandBus = commandBus;
        }

        [HttpGet("{key}")]
        public async Task<string> Get(string key) {
            return await _queryProcessor.ProcessAsync(new GetDataQuery(key), CancellationToken.None);
        }

        [HttpPost]
        public async void Post([FromBody] SetDataCommand command) {
            await _commandBus.PublishAsync(command, CancellationToken.None);
        }

        [HttpDelete("{key}")]
        public async void Delete(string key) {
            await _commandBus.PublishAsync(new DeleteDataCommand(key), CancellationToken.None);
        }
    }
}