using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Move is called on Ship Cursor move
    public static void Move(float horizontal, float vertical, GameObject ship)
    {
        Vector3 currentv = ship.transform.position;
        currentv.x = currentv.x + horizontal;
        currentv.y = currentv.y + vertical;
        ship.transform.TransformVector(currentv);
    }

}
