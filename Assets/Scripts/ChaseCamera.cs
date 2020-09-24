using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f;

        // Weighted bias for camera follow spring function
        float bias = 0.96f;

        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f - bias);
        Camera.main.transform.LookAt(transform.position + transform.forward * 30f);
    }
}
