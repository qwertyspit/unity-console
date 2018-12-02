using Assets.Commands.Core;

namespace Assets.Commands.Common
{
  [ConsoleCommand]
  public class Cls : IConsoleCommand
  {
    private IConsoleDisplay _display;

    public ConsoleCommandInfo Info()
    {
      return ConsoleCommandInfo.Empty;
    }

    public IConsoleCommand Output(IConsoleDisplay display)
    {
      _display = display;
      return this;
    }

    public IConsoleCommand Execute(string parameters)
    {
      _display.Clear();
      return this;
    }
  }
}
