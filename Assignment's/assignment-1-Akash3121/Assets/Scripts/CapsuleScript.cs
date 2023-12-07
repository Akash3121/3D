using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float starty = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        starty = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(Time.time), starty, 0.0f);
    }
}
