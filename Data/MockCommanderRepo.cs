using dotnet_api_les_jackson.Models;

namespace dotnet_api_les_jackson.Data;

public class MockCommanderRepo : ICommanderRepo
{
    public IEnumerable<Command> GetAppCommands()
    {
        throw new NotImplementedException();
    }

    public Command GetCommandById(int id)
    {
        return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
    }
}