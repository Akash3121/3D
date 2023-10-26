using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKiller : MonoBehaviour
{
    /*   // public float timeToLive = 1.0f;
       // private float timeLived = 0.0f;

       // Start is called before the first frame update
       void Start()
       {

       }

       // Update is called once per frame
       void Update()
       {
           Debug.Log("Update called in CubeKiller");
           // Debug.Log("Player position: " + playerPosition);
           // Check if the cube is behind the player
           if (IsBehindPlayer())
           {
               Destroy(gameObject);
           }
       }

       bool IsBehindPlayer()
       {

           // Assuming the player is at (0, 0, 0)
           Vector3 playerPosition = Vector3.zero;
           Vector3 cubePosition = transform.position;

           Debug.Log("Cube position: " + cubePosition);

           // Check if the cube is behind the player in the Z-axis
           return cubePosition.z < playerPosition.z;
       }
   */

    /*private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the destruction plane
        // if (collision.gameObject.CompareTag("DestructionPlane"))
        if (collision.tag == "DestructionPlane")
        {
            Debug.Log("Inside OnCollision");
            Destroy(collision.gameObject); // Destroy the cube
        }
    } */

    /* private void OnCollisionEnter(Collision other)
    {
        //if (other.tag == "DestructionPlane")
        if(other.gameObject.tag =="Cube")
        {
            Debug.Log("Inside OnCollision");
            // Destroy the cube
            Destroy(other.gameObject);
        }
    } */

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube" || other.tag == "Arrow" || other.tag == "RedCube") // when these cubes touches the plane the gameObjects gets destroyed
        {
            // Debug.Log("Inside OnTriggerEnter");
            // Destroy(other.gameObject); // Destroy the cube
            Destroy(other.transform.parent.gameObject);
        }
    }
}
