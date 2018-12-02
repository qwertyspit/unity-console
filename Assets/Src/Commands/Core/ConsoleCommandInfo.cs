namespace Assets.Commands.Core
{
  public class ConsoleCommandInfo
  {
    public static ConsoleCommandInfo Empty = new ConsoleCommandInfo(string.Empty, string.Empty);

    public string Description { get; private set; }
    public string Example { get; private set; }

    public ConsoleCommandInfo(string description, string example)
    {
      Description = description;
      Example = example;
    }
  }
}