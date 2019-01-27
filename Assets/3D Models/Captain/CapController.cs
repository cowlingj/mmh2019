using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CapController : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    public Animator animator;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
        float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        if (vertical <= 0)
        {
            animator.SetInteger("Conditional", 0);
            return;
        }
        animator.SetInteger("Conditional", 1);
        transform.position += new Vector3(100, 100, 100);

    }
}