using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShipBehaviour : MonoBehaviour
{

    // Update is called once per frame
    public void Update()
    {
        const float multiplier = 0.1F;

        Component ship = GetComponent<Component>();

        float vertical = multiplier * CrossPlatformInputManager.GetAxis("Vertical");
        float horizontal = multiplier * CrossPlatformInputManager.GetAxis("Horizontal");

        bool returnkey = CrossPlatformInputManager.GetButton("Submit");

        Movement.Move(horizontal, vertical, ship);
    }
}