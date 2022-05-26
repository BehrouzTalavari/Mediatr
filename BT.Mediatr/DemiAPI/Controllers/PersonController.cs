using Microsoft.AspNetCore.Mvc;
using MediatR;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using DemoLibrary.Commands;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonalModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonalModel> GetAsync(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));

        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonalModel> Post([FromBody] PersonalModel value)
        { 
            return await _mediator.Send(new InsertPersonCommand(value.FirstName, value.LastName));
        }

    }
}
