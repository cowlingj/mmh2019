using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

  public GameObject target;
  private Vector3 cameraOffset;

  private void Awake()
  {
    cameraOffset = GetComponent<Component>().transform.position - target.transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    transform.position = target.transform.position + cameraOffset;
  }
}
