using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlanetTrigger : MonoBehaviour
{

    private bool insidePlanet = false;
    private Trigger trigger;

    // Start is called before the first frame update
    void Awake()
    {
        trigger = new Trigger(()=>{
            Debug.Log("collision detected");
        }, ()=>{
            return insidePlanet
              && CrossPlatformInputManager.GetButton("Submit");
            });
    }

    // Update is called once per frame
    void Update()
    {
        trigger.TestTrigger();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        insidePlanet = true;
    }

    private void OnTriggerStay2D(Collider2D other) {
        insidePlanet = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        insidePlanet = false;
    }
}
