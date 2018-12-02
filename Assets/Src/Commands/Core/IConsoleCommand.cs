namespace Assets.Commands.Core
{
  public interface IConsoleCommand
  {
    ConsoleCommandInfo Info();
    IConsoleCommand Output(IConsoleDisplay display);
    IConsoleCommand Execute(string parameters);
  }
}