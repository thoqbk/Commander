using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Dtos;
using Commander.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Commander.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : ControllerBase
    {

        private readonly ILogger<CommandsController> _logger;
        private readonly ICommanderRepository _commanderRepository;

        public CommandsController(ILogger<CommandsController> logger, ICommanderRepository commanderRepository)
        {
            _logger = logger;
            _commanderRepository = commanderRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CommandDto>> GetAllCommands()
        {
            var commands = _commanderRepository.GetAllCommands();
            var retVal = commands.Select(c => new CommandDto
            {
                Id = c.Id,
                HowTo = c.HowTo,
                Line = c.Line
            });
            return retVal.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<CommandDto> GetCommandById(int id)
        {
            var command = _commanderRepository.GetCommandById(id);
            if (command == null)
            {
                return null;
            }
            return new CommandDto
            {
                Id = command.Id,
                HowTo = command.HowTo,
                Line = command.Line
            };
        }
    }
}
