using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogRunner
{
    private Dialog dialog;
    private DialogControls controls;
  private int step = 0;
  private bool dialogInProgress = false;

  public DialogRunner(Dialog dialog, DialogControls controls) {
        this.dialog = dialog;
        this.controls = controls;
    }

    public bool DialogInProgress() {
        return dialogInProgress;
    }

    public void StartDialog() {
        if (dialogInProgress) {
            return;
        }
        controls.Open();
        dialogInProgress = true;
        ContinueDialog();
    }

    private void ContinueDialog() {
        if (step == -1) {
            step = 0;
            controls.Close();
            dialogInProgress = false;
            return;
        }

        controls.UpdatePhrase(dialog.steps[step].phrase);
        controls.AddOptions(dialog.steps[step].options, (int choice) => {
            step = choice;
            ContinueDialog();
        });
    }

}
