using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGrab : MonoBehaviour
{
    public string grabbableTag = "grabbable";
    public float throwForce = 7f;

    private GameObject grabbed = null;
    private Vector3 grabbedOffset = Vector3.zero;
    private Vector3 lastControllerPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastControllerPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbed != null)
        {
            if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) < 0.05f) // if clicked trigger very slightly
            {
                //trigger relased
                //grabbed.GetComponent<Rigidbody>().isKinematic = false;
                Rigidbody grabbedRigidbody = grabbed.GetComponent<Rigidbody>();
                grabbedRigidbody.isKinematic = false;

                Vector3 throwVelocity = (this.transform.position - lastControllerPosition) * throwForce;
                grabbedRigidbody.velocity = throwVelocity;
                
                grabbed = null;
            }
            else
            {
                grabbed.transform.position = this.transform.position + grabbedOffset;
            }
            lastControllerPosition = this.transform.position;
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (grabbed == null)
        {
            if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) > 0.9f && other.gameObject.tag == grabbableTag)
            {
                grabbed = other.gameObject;
                grabbedOffset = grabbed.transform.position - this.transform.position; // here this refers to controller, subtracting current object position(this) with initial object position(grabbed) and putting it in grabbedOffset, this grabbedOffset is added to this.transform in update function
                
                grabbed.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
