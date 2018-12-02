using Assets.Commands.Core;

namespace Assets.Commands.Common
{
  [ConsoleCommand]
  public class DoingNothing : IConsoleCommand
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
      if (_display != null)
        _display.Output(string.Concat("] ", parameters));

      return this;
    }
  }
}
