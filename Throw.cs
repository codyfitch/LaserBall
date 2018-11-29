using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

    public OVRInput.Controller controller;
   /* public string buttonName;
    private GameObject grabbedObject;
    private bool grabbing;*/
    public int speed;
    public GameObject ball;

    void ThrowObject()
    {
            ball.GetComponent<Rigidbody>().velocity = OVRInput.GetLocalControllerVelocity(controller) * speed;
    }
   /* void DropObject()
    {
        grabbing = false;

        if(grabbedObject != null)
        {
            grabbedObject.transform.parent = null;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            grabbedObject.GetComponent<Rigidbody>().velocity = OVRInput.GetLocalControllerVelocity(controller) * speed;

            grabbedObject = null;
        }
    }

    private void Update()
    {
        if (grabbing && Input.GetAxis(buttonName) < 1)
        {
            DropObject();
        }
    }
    */
}
