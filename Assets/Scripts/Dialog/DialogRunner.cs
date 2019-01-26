using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogRunner
{
    private Dialog dialog;
    private int step = 0;
    public DialogRunner(Dialog dialog) {
        this.dialog = dialog;
    }

    public void StartDialog() {
        ContinueDialog();
    }

    public void ContinueDialog() {
        if (step == -1) {
            EndDialog();
            return;
        }

        Debug.Log(dialog.steps[step].phrase);
        foreach(Dialog.Option option in dialog.steps[step].options) {
            Debug.Log(option.choice);
        }
    }

    public void EndDialog() {
        Debug.Log("End Dialog");
    }

    public void ChooseOption(int choice) {
        step = dialog.steps[step].options[choice].newPhraseIndex;
        ContinueDialog();
    }
}
