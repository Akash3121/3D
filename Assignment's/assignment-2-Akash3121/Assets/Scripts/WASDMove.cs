using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDmove : MonoBehaviour
{
    public float movementSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0.0f, 0.0f, movementSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0.0f, 0.0f, -movementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-movementSpeed * Time.deltaTime, 0.0f, 0.0f));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0.0f, 0.0f));
        }
    }
}
