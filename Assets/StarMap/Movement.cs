using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    // Move is called on Ship Cursor move
    public static void Move(float horizontal, float vertical, Component ship)
    { 
        Vector3 currentv = ship.transform.position;
        currentv.x = currentv.x + horizontal;
        currentv.y = currentv.y + vertical;
        ship.transform.position = currentv;
        //Debug.Log("Position now: x = " + currentv.x + " y = " + currentv.y);
    }

}
