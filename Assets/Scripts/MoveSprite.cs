using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveSprite : MonoBehaviour
{

    public float linearSpeedMultiplier = 100f;
    public float maxLinearVelocity = 500f;
    public float angularSpeedMultiplier = 100f;
    public float maxAngularVelocity = 100f;

    public bool invertAxis = false;

    void FixedUpdate()
    {
        int invertMultiplier = invertAxis? 1 : -1;
        float x = invertMultiplier * Time.deltaTime *  angularSpeedMultiplier * CrossPlatformInputManager.GetAxis("Horizontal");
        float y = Time.deltaTime * linearSpeedMultiplier * CrossPlatformInputManager.GetAxis("Vertical");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.AddTorque(x);
        rb.AddForce(transform.TransformVector(new Vector2(0, y)));
    
        if (Mathf.Abs(rb.angularVelocity) > maxAngularVelocity) {
            rb.angularVelocity = Mathf.Sign(rb.angularVelocity) * maxAngularVelocity;
        }

        if (rb.velocity.magnitude > maxLinearVelocity) {
            rb.velocity = rb.velocity.normalized * maxLinearVelocity;
        }
    }
}
