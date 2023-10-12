using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    private float startz = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        startz = transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0.0f, Mathf.Sin(Time.time), startz);
    }
}
