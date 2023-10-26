using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlade : MonoBehaviour
{
    /*    public AudioClip destroySound; // sound added in Lightsaber, check in inspector
        private AudioSource audioSource;

        // Start is called before the first frame update
        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            // Debug.Log("Trigger entered with object: " + other.name);
            // if (other.tag == "Arrow") // if it is "Arrow" it is destroying when blade has touched the quad - working
            if (other.tag == "Cube")
            {
                // Play the destroySound
                audioSource.clip = destroySound;
                audioSource.Play();

                // Destroy the cube
                // Destroy(other.gameObject);
                Destroy(other.transform.parent.gameObject);
            }
        } 
    */

    /*   public AudioClip destroySound; // sound added in Lightsaber, check in inspector
       private AudioSource audioSource;

       private Rigidbody bladeRigidbody; // Reference to the rigid body

       // Start is called before the first frame update
       void Start()
       {
           audioSource = GetComponent<AudioSource>();
           bladeRigidbody = GetComponent<Rigidbody>(); // Get the rigid body component
       }

       // Update is called once per frame
       void Update()
       {

       }

       private void OnTriggerEnter(Collider other)
       {
                  // Debug.Log("Trigger entered with object: " + other.name);
                  // if (other.tag == "Arrow") // if it is "Arrow" it is destroying when blade has touched the quad - working
                  if (other.tag == "Cube")
                  {
                      Debug.Log("Trigger entered with object: " + other.name);

                      // Check the direction of the sword swing
                      Vector3 swordSwingDirection = bladeRigidbody.velocity.normalized;
                      Debug.Log("swordSwingDirection" + swordSwingDirection);
                      // Get the direction of the arrow on the cube (you might need to adjust this based on your setup)
                      Vector3 arrowDirection = other.transform.forward;
                      Debug.Log("arrowDirection " + arrowDirection);

                      Debug.Log("Dot:  " + Vector3.Dot(swordSwingDirection, arrowDirection));

                      // Compare the directions (you may need to fine-tune this condition based on your setup)
                      // if (Vector3.Dot(swordSwingDirection, arrowDirection) > 0.5f)
                      // if (Vector3.Dot(swordSwingDirection, arrowDirection) >= 0.0f && Vector3.Dot(swordSwingDirection, arrowDirection) <= 0.4f)
                      if (Vector3.Dot(swordSwingDirection, arrowDirection) <= 0.1f && Vector3.Dot(swordSwingDirection, arrowDirection) >= -0.4f)
                          {
                          Debug.Log("Inside Destroy" );
                          // Play the destroySound
                          audioSource.clip = destroySound;
                          audioSource.Play();

                          // Destroy the cube only if the sword is swung in the right direction
                          Destroy(other.transform.parent.gameObject);
                      }
                  } 
           // Define a threshold angle for similarity  
       } */
    public AudioClip destroySound; // sound added in Lightsaber, check in inspector
    private AudioSource audioSource;
    private Vector3 previousPosition;

    private Rigidbody bladeRigidbody; // Reference to the rigid body

    // Define a threshold angle for similarity
    float angleThreshold = 130.0f; // You can adjust this value based on your requirements

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // bladeRigidbody = GetComponent<Rigidbody>(); // Get the rigid body component
        previousPosition = transform.position; // Initialize the previous position

    }

    // Update is called once per frame
    void Update()
    {
        // Update the previous position in each frame
        previousPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.tag == "Arrow") // if it is "Arrow" it is destroying when blade has touched the quad - working
        if (other.tag == "RedCube")
        {
            Debug.Log("Trigger entered with object: " + other.name);

            // Check the direction of the sword swing
            // Vector3 swordSwingDirection = bladeRigidbody.velocity.normalized;
            Vector3 swordSwingDirection = (transform.position - previousPosition).normalized;
            Debug.Log("swordSwingDirection: " + swordSwingDirection);

            // Get the direction of the arrow on the cube (you might need to adjust this based on your setup)
            // Vector3 arrowDirection = other.transform.forward;
            Vector3 arrowDirection = other.transform.up; //we are checking top of cube and swod swing angle 

            Debug.Log("arrowDirection: " + arrowDirection);

            // Get the angle between the sword swing direction and arrow direction
            float angle = Vector3.Angle(swordSwingDirection, arrowDirection);
            Debug.Log("Angle: " + angle);

            // Check if the angle is within the threshold
            if (angle > angleThreshold) 
            {
                // Play the destroySound
                audioSource.clip = destroySound;
                audioSource.Play();

                // Destroy the cube only if the sword is swung in the right direction
                Destroy(other.transform.parent.gameObject);
            }

            previousPosition = transform.position;
        }
    }
}
