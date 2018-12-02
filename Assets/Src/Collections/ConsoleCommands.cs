using System;
using Assets.Commands.Core;

namespace Assets.Collections
{
  public class ConsoleCommands
  {
    private static readonly ConsoleCommandTypes _types = new ConsoleCommandTypes();

    public IConsoleCommand Find(string name)
    {
      return Activator.CreateInstance(_types.Find(name)) as IConsoleCommand;
    }
  }
}