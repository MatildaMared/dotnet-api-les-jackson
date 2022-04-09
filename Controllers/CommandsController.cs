using dotnet_api_les_jackson.Data;
using dotnet_api_les_jackson.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_api_les_jackson.Controllers;

// api/commands
[Route("api/[controller]")]
[ApiController]
public class CommandsController : ControllerBase
{
    private readonly MockCommanderRepo _repository = new MockCommanderRepo();

    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {
        var commandItems = _repository.GetAppCommands();

        return Ok(commandItems);
    }

    // GET api/commands/5
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id)
    {
        var commandItem = _repository.GetCommandById(id);

        return Ok(commandItem);
    }
}