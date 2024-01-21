using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2.0f;
    public Camera camera;
    public Vector3 startingPosition = new Vector3(0, 10f, 0);
    public float startingCameraSize = 240.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (camera.orthographicSize > 2)
            {
                camera.orthographicSize -= speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            camera.orthographicSize += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)) 
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = startingPosition;
            camera.orthographicSize = startingCameraSize;
        }
    }

}
