using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothBehaviorMouse : MonoBehaviour
{
    public float speed = 50f;
    public float lookSpeed = 90f;
    private Vector2 mousePos, screenCenter, mouseDistance;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mouse Version of script started on " + gameObject.name);

        screenCenter.x = Screen.width / 2;
        screenCenter.y = Screen.height / 2;

        mousePos = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {

        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;

        mouseDistance.x = (mousePos.x - screenCenter.x) / screenCenter.x;
        mouseDistance.y = (mousePos.y - screenCenter.y) / screenCenter.y;



        transform.position += transform.forward * Time.deltaTime * speed;

        speed -= transform.forward.y * Time.deltaTime * 30.0f;

        if (speed < 35.0f) speed = 35.0f;

        transform.Rotate(-mouseDistance.y * lookSpeed * Time.deltaTime, mouseDistance.x * lookSpeed * Time.deltaTime, 0f, Space.Self);

        //float terrainHeightAtMothLocation = Terrain.activeTerrain.SampleHeight(transform.position);

        //if (terrainHeightAtMothLocation > transform.position.y)
        //{
        //    transform.position = new Vector3(transform.position.x, terrainHeightAtMothLocation, transform.position.z);
        //}
    }
}
