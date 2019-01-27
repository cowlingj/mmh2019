using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public Dialog.Step[] steps;
  
  [System.Serializable]
  public class Step
  {
      [TextArea(3, 10)]
      public string phrase;

      public Dialog.Option[] options;

  }

  [System.Serializable]
  public class Option
  {
      [TextArea(1, 5)]
      public string choice;
      public int newPhraseIndex;
  }
}
