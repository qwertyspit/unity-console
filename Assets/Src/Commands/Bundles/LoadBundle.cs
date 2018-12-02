using System;
using Assets.Commands.Core;

namespace Assets.Commands.Bundles
{
  [ConsoleCommand]
  public class LoadBundle : IConsoleCommand
  {
    public ConsoleCommandInfo Info()
    {
      return new ConsoleCommandInfo("Loading bundle by url", "loadbundle http://servername/bundle.unity3d");
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