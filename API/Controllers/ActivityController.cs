using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> List()
        {
            return await _mediator.Send(new List.Query());
        }
        [HttpGet]
        [Route("Details")]
        public async Task<ActionResult<Activity>> Details(Guid id)
        {
            return await _mediator.Send(new Details.Query{Id = id});
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<int>> Create(Create.Command command)
        { 
            return await _mediator.Send(command);
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<int>> Delete(Guid id)
        {
            return await _mediator.Send(new Delete.Command{ Id = id});
        }    

        [HttpPut]
        public async Task<ActionResult<int>> Edit(Guid guid, Edit.EditCommand command)
        {
            command.guid = guid;
            return await _mediator.Send(command);
        }  
    }
}