using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Behaviour : MonoBehaviour
{

    public GameObject ship; 

    // Update is called once per frame
    void Update()
    {
        float vertical = CrossPlatformInputManager.GetAxis("Veritcal");
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");

        bool returnkey = CrossPlatformInputManager.GetButton("return");

        if (returnkey)
        {
            //GotoPlanet
        }
        else
        {
            Movement.Move(horizontal, vertical, ship);
        }
    }
}