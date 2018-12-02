using UnityEngine;

namespace Assets
{
  public class ConsoleControl : MonoBehaviour
  {
    public GameObject Template;
    private Console _console;

    protected void Update()
    {
      if (Input.GetKeyDown(KeyCode.BackQuote))
      {
        if (_console == null)
        {
          _console = Console.From(Template, transform);
          return;
        }

        if (_console.IsOpen)
          _console.Close();
        else
          _console.Open();
      }
    }
  }
}
