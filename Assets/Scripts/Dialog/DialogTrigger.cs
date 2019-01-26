using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DialogTrigger : MonoBehaviour
{

  private bool ShouldTriggerDialog() {
    return CrossPlatformInputManager.GetButton("Submit")
      && Vector3.Distance(transform.position, target.transform.position) > 0;
  }

  public Trigger trigger;

  private void Update() {
    trigger.TestTrigger();
  }

  public GameObject target;

  private DialogRunner runner;
    
  private void Awake() {
    runner = new DialogRunner(dialog);
    trigger = new Trigger(() => runner.StartDialog(), ShouldTriggerDialog);
  }
  public Dialog dialog;
}