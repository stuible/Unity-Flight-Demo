using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothBehavior : MonoBehaviour
{
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("script started on " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

        speed -= transform.forward.y * Time.deltaTime  * 30.0f;

        if (speed < 35.0f) speed = 35.0f;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        //float terrainHeightAtMothLocation = Terrain.activeTerrain.SampleHeight(transform.position);

        //if (terrainHeightAtMothLocation > transform.position.y)
        //{
        //    transform.position = new Vector3(transform.position.x, terrainHeightAtMothLocation, transform.position.z);
        //}
    }
}
