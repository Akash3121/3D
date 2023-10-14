using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float movementSpeed = 8.0f;
    public float rotationSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check to make sure button works
        if (OVRInput.GetDown(OVRInput.RawTouch.X))
        {
            Debug.Log("Pressed X!");
        }

        // Joystick movement
        Vector2 movement = new Vector2(movementSpeed, movementSpeed);
        movement *= OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        movement *= Time.deltaTime;
        transform.Translate(new Vector3(movement.x, 0.0f, movement.y));

        // Joystick Rotation
        float rotation = rotationSpeed * Time.deltaTime * OVRInput.Get(OVRInput.RawAxis2D.LThumbstick).x;
        transform.Rotate(Vector3.up, rotation, Space.World);
    }
}
