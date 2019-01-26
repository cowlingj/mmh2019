using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Planet : MonoBehaviour
{
    public GameObject target;

    private bool ShouldTriggerPopUp()
    {
        Debug.Log(CrossPlatformInputManager.GetButton("Submit")
          && Vector3.Distance(transform.position, target.transform.position) < 3);
        return CrossPlatformInputManager.GetButton("Submit")
          && Vector3.Distance(transform.position, target.transform.position) < 3;
    }

    public Trigger ActivatePopUp;

    void Update()
    {
        ActivatePopUp.TestTrigger();
    }

    private void Awake()
    {
        ActivatePopUp = new Trigger(() => Landing.LandOnPlanet(), ShouldTriggerPopUp);
       
    }
    public Dialog dialog;
}
