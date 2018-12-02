namespace Assets.Commands.Core
{
  public interface IConsoleDisplay
  {
    void Output(string message);
    void Clear();
  }
}