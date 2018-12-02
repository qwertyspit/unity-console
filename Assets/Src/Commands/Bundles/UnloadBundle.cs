using System;
using Assets.Commands.Core;

namespace Assets.Commands.Bundles
{
  [ConsoleCommand]
  public class UnloadBundle : IConsoleCommand
  {
    public ConsoleCommandInfo Info()
    {
      return new ConsoleCommandInfo("Unloads specific bundle", "unloadbundle bundlename.unity3d");
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
