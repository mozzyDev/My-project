using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public Transform ballTransform;
    public GameObject sphereObject;
    public Vector3 distance;
    public float lookUp;
    public float lerpAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, sphereObject.transform.position + distance, lerpAmount);
        transform.LookAt(sphereObject.transform.position);
        transform.Rotate(-lookUp, 0, 0);
    }

}
