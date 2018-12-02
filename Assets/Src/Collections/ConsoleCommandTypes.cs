using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Assets.Commands.Common;
using Assets.Commands.Core;

namespace Assets.Collections
{
  public class ConsoleCommandTypes : ReadOnlyCollection<Type>
  {
    private static readonly List<Type> Types;

    static ConsoleCommandTypes()
    {
      Types = new List<Type>();

      foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        Types.AddRange(assembly.GetTypes().Where(type => type.GetCustomAttributes(typeof(ConsoleCommandAttribute), true).Length > 0));
    }

    public ConsoleCommandTypes() : base(Types) { }

    public Type Find(string name)
    {
      var type = Types.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
      return type ?? typeof(DoingNothing);
    }
  }
}