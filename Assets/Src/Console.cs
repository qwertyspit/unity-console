using System;
using Assets.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
  public class Console : MonoBehaviour
  {
    public InputField Input;
    public ConsoleDisplay Display;
    
    public bool IsOpen { get { return gameObject.activeSelf; } }

    public void Open()
    {
      gameObject.SetActive(true);
    }

    public void Close()
    {
      gameObject.SetActive(false);
    }

    public void Submit()
    {
      Display.Output(string.Concat("] ", Input.text));

      var input = Input.text;
      var parametersStartIndex = input.IndexOf(" ", StringComparison.Ordinal);
      var parameters = parametersStartIndex < 0 ? string.Empty : input.Substring(parametersStartIndex);
      var commandName = parametersStartIndex < 0 ? input : input.Substring(0, parametersStartIndex);
      var command = new ConsoleCommands().Find(commandName);
      command.Output(Display).Execute(parameters.Trim());

      Input.text = string.Empty;
    }

    protected void OnEnable()
    {
      Focus();
    }

    protected void Update()
    {
      if (UnityEngine.Input.GetKeyUp(KeyCode.Return) && !string.IsNullOrEmpty(Input.text))
      {
        Submit();
        Focus();
      }
    }

    private void Focus()
    {
      Input.Select();
      Input.ActivateInputField();
    }

    public static Console From(GameObject template, Transform parent)
    {
      return Instantiate(template, parent).GetComponent<Console>();
    }
  }
}
