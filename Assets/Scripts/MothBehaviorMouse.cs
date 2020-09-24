using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothBehaviorMouse : MonoBehaviour
{
    public float speed = 50f;
    public Vector2 mousePos;
    public Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mouse Version of script started on " + gameObject.name);

        point = new Vector3();
        mousePos = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Event currentEvent = Event.current;
        

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = Event.current.mousePosition.x;
        mousePos.y = Camera.main.pixelHeight - Event.current.mousePosition.y;

        point = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));



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
