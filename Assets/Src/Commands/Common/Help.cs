using System;
using System.Text;
using Assets.Collections;
using Assets.Commands.Core;

namespace Assets.Commands.Common
{
  [ConsoleCommand]
  public class Help : IConsoleCommand
  {
    private readonly StringBuilder _output = new StringBuilder();
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
      if (!string.IsNullOrEmpty(parameters))
      {
        var command = new ConsoleCommands().Find(parameters);
        if (command is DoingNothing)
          return this;

        Append(parameters, command.Info());
        _display.Output(_output.ToString());
        return this;
      }

      foreach (var availableCommand in new ConsoleCommandTypes())
      {
        var obj = Activator.CreateInstance(availableCommand) as IConsoleCommand;
        Append(availableCommand.Name, obj.Info());
        _output.AppendLine();
      }

      _display.Output(_output.ToString());

      return this;
    }

    private void Append(string commandName, ConsoleCommandInfo info)
    {
      _output.AppendLine(string.IsNullOrEmpty(info.Description)
        ? string.Format("{0}", commandName)
        : string.Format("{0} - {1}", commandName, info.Description));
      
      if (!string.IsNullOrEmpty(info.Example))
        _output.AppendLine(string.Format("<i>{0}</i>", info.Example));
    }
  }
}
