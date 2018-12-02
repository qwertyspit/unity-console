using System.Text;
using Assets.Commands.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
  public class ConsoleDisplay : MonoBehaviour, IConsoleDisplay
  {
    public Text Display;
    private StringBuilder _output = new StringBuilder();

    public void Output(string message)
    {
      _output.AppendLine(message);
      Display.text = _output.ToString();
    }

    public void Clear()
    {
      _output = new StringBuilder();
      Display.text = string.Empty;
    }
  }
}