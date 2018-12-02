using System;
using Assets.Commands.Core;

namespace Assets.Commands.Forms
{
  [ConsoleCommand]
  public class OpenForm : IConsoleCommand
  {
    public ConsoleCommandInfo Info()
    {
      return new ConsoleCommandInfo("Opens specific form", "openform BlackMarketForm");
    }

    public IConsoleCommand Output(IConsoleDisplay display)
    {
      throw new NotImplementedException();
    }

    public IConsoleCommand Execute(string parameters)
    {
      throw new NotImplementedException();
    }
  }
}
