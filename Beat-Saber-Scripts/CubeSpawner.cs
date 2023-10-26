using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    /* public GameObject cube;
    public Vector3 spawnOffset;
    public float xRange = 0.45f;
    public float yRange = 0.45f;
    public float minDistance = 12f; // Minimum distance from the player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B) || OVRInput.GetDown(OVRInput.RawButton.Y) || Input.GetKeyDown(KeyCode.A))
        {

            // Randomize X and Y positions 
            float x = UnityEngine.Random.Range(-xRange, xRange);
            float y = UnityEngine.Random.Range(-yRange / 4.0f, yRange);
            // float z = UnityEngine.Random.Range(0, spawnOffset.z);

            // Calculate spawn position
            Vector3 spawnPos = transform.position - new Vector3(0.0f, 0.0f, spawnOffset.z);

            // Calculate direction towards the player
            Vector3 directionToPlayer = (transform.position - spawnPos).normalized;

            // Adjust initial position based on direction and distance

            // float distanceToPlayer = minDistance;
            // Vector3 initialPos = transform.position + directionToPlayer * distanceToPlayer;
            // Vector3 initialPos = spawnPos - directionToPlayer * distanceToPlayer;
            Vector3 initialPos = new Vector3(x, y, 0.0f) + directionToPlayer * minDistance;

            // Spawn Cube
            GameObject go = GameObject.Instantiate(cube, initialPos, Quaternion.identity);

            // Get the Cube child object
            go = go.transform.Find("Cube").gameObject;

            // Get Rigidbody
            Rigidbody rb = go.GetComponent<Rigidbody>();

            rb.useGravity = false;

            // Calculate random velocity direction
            float theta = UnityEngine.Random.Range((float)(Math.PI / 4.0f), (float)(3.0f * Math.PI / 4.0f));
            float mag = UnityEngine.Random.Range(1.0f, 3.0f);

            // Calculate added velocity
            Vector3 addedVelocity = -directionToPlayer * mag;

            // Apply force to move towards the player
            rb.AddForce(addedVelocity, ForceMode.VelocityChange);

            // Adjust cube scale
            float scale = UnityEngine.Random.Range(0.1f, 0.25f);
            go.transform.localScale = new Vector3(scale, scale, scale);
        }
    } */
    /*   public GameObject cube;
       public Vector3 spawnOffset = new Vector3(0.0f, 1.5f, 1.0f);
       public float xRange = 0.35f;
       public float yRange = 0.4f;
       public float minDistance = 12f; // Minimum distance from the player
       public float minSpawnDelay = 1.5f;
       public float maxSpawnDelay = 2.0f;

       private float lastSpawnTime;

       // Start is called before the first frame update
       void Start()
       {
           lastSpawnTime = Time.time;
       }

       // Update is called once per frame
       void Update()
       {
           if (CanSpawnCube())
           {
               SpawnCube();
           }
       }

       bool CanSpawnCube()
       {
           float elapsedTimeSinceLastSpawn = Time.time - lastSpawnTime;
           float randomSpawnDelay = UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay);

           return elapsedTimeSinceLastSpawn > randomSpawnDelay;
       }

       void SpawnCube()
       {
           // Randomize X and Y positions
           float x = UnityEngine.Random.Range(-xRange, xRange);
           float y = UnityEngine.Random.Range(-yRange / 4.0f, yRange);

           // Calculate spawn position
           Vector3 spawnPos = transform.position - new Vector3(0.0f, 0.0f, spawnOffset.z);

           // Calculate direction towards the player
           Vector3 directionToPlayer = (transform.position - spawnPos).normalized;

           // Adjust initial position based on direction and distance
           Vector3 initialPos = new Vector3(x, y, 0.0f) + directionToPlayer * minDistance;

           // Spawn Cube
           GameObject go = Instantiate(cube, initialPos, Quaternion.identity);
           go = go.transform.Find("Cube").gameObject;

           // Get Rigidbody
           Rigidbody rb = go.GetComponent<Rigidbody>();
           rb.useGravity = false;

           // Calculate random velocity direction
           float theta = UnityEngine.Random.Range((float)(Math.PI / 4.0f), (float)(3.0f * Math.PI / 4.0f));
           float mag = UnityEngine.Random.Range(1.0f, 3.0f);

           // Calculate added velocity
           Vector3 addedVelocity = -directionToPlayer * mag;

           // Apply force to move towards the player
           rb.AddForce(addedVelocity, ForceMode.VelocityChange);

           // Adjust cube scale
           float scale = UnityEngine.Random.Range(0.1f, 0.25f);
           go.transform.localScale = new Vector3(scale, scale, scale);

           // Update last spawn time
           lastSpawnTime = Time.time;
       } */

    public GameObject cube;
    public GameObject RedCube;
    public Vector3 spawnOffset = new Vector3(0.0f, 1.5f, 1.0f);
    public float xRange = 0.8f;
    public float yRange = 0.45f;
    public float minDistance = 12f; // Minimum distance from the player
    public float minSpawnDelay = 1.5f;
    public float maxSpawnDelay = 2.0f;

    public float beat = 60 / 105;
    private float timer;

    private float lastSpawnTime;
    private bool canSpawn = true; // Variable to control spawning

    // Start is called before the first frame update
    void Start()
    {
        lastSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            if (canSpawn && CanSpawnCube())
            {
                SpawnCube();
            }

            timer -= beat;
        }
        

        // Check if the 'Q' key is pressed or 'B' key is pressed
        if (Input.GetKeyDown(KeyCode.Q) || OVRInput.GetDown(OVRInput.RawButton.B))
        {
            // Toggle spawning when the 'Q' key is pressed
            ToggleSpawn();
        }

        timer += Time.deltaTime;
    }

    bool CanSpawnCube()
    {
        float elapsedTimeSinceLastSpawn = Time.time - lastSpawnTime;
        float randomSpawnDelay = UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay);

        return elapsedTimeSinceLastSpawn > randomSpawnDelay;
    }

    void SpawnCube()
    {
        float x = UnityEngine.Random.Range(-xRange, xRange);
        float y = UnityEngine.Random.Range(-yRange / 4.0f, yRange);

        float xr = UnityEngine.Random.Range(-xRange, xRange);
        float yr = UnityEngine.Random.Range(-yRange / 4.0f, yRange);

        Vector3 spawnPos = transform.position - new Vector3(0.0f, 0.0f, spawnOffset.z);
        Vector3 directionToPlayer = (transform.position - spawnPos).normalized;
        Vector3 initialPos = new Vector3(x, y, 0.0f) + directionToPlayer * minDistance;
        
        Vector3 initialPosRed = new Vector3(xr, yr, 0.0f) + directionToPlayer * minDistance;
        // Vector3 initialPos = new Vector3(0.0f, 1.5f, 0.0f) + directionToPlayer * minDistance; // change this

        // BlueCube is Cube
        GameObject blue = Instantiate(cube, initialPos, Quaternion.identity);
        blue = blue.transform.Find("Cube").gameObject;

        blue.transform.Rotate(transform.forward, 90 * UnityEngine.Random.Range(0, 4));

        Rigidbody rbBlue = blue.GetComponent<Rigidbody>();
        rbBlue.useGravity = false;

        // RedCube is Cube
        GameObject red = Instantiate(RedCube, initialPosRed, Quaternion.identity);
        red = red.transform.Find("Cube").gameObject;

        red.transform.Rotate(transform.forward, 90 * UnityEngine.Random.Range(0, 4));

        Rigidbody rbRed = red.GetComponent<Rigidbody>();
        rbRed.useGravity = false;


        float theta = UnityEngine.Random.Range((float)(Math.PI / 4.0f), (float)(3.0f * Math.PI / 4.0f));
        float mag = UnityEngine.Random.Range(1.0f, 3.0f);
        Vector3 addedVelocity = -directionToPlayer * mag;

        rbBlue.AddForce(addedVelocity, ForceMode.VelocityChange);
        rbRed.AddForce(addedVelocity, ForceMode.VelocityChange);
        
        
        float scale = UnityEngine.Random.Range(0.1f, 0.25f);
        blue.transform.localScale = new Vector3(scale, scale, scale);
        red.transform.localScale = new Vector3(scale, scale, scale);

        lastSpawnTime = Time.time;
    }

    // Method to toggle spawning on/off
    public void ToggleSpawn()
    {
        canSpawn = !canSpawn;
    }
}

