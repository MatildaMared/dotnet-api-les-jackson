using dotnet_api_les_jackson.Models;

namespace dotnet_api_les_jackson.Data;

public interface ICommanderRepo
{
    IEnumerable<Command> GetAppCommands();

    Command GetCommandById(int id);
}