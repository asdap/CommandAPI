using System.Collections.Generic;
using CommandAPI.Models;
namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}