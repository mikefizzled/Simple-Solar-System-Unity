using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera current;
    public Camera birdsEye;
    public Camera earth;

    public float speed = 3.0f;

    public Vector3 earthStart = new Vector3(2.5f, 1.3f, -0.275f);
    public Vector3 birdStart = new Vector3(0, 985.76f, 0);

    public float earthSize = 100.0f;
    public float birdSize = 100f;
    public float multiplier = 5f;
    public bool boost = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            boost = true;
        else
            boost = false;

        if(boost)
            multiplier = 5.0f;
        else
            multiplier = 1f;

        if(Input.GetKeyDown(KeyCode.Keypad1)||Input.GetKeyDown(KeyCode.Alpha1)) {
            earth.enabled = false;
            birdsEye.enabled = true;
            current = birdsEye;
        }
        if(Input.GetKeyDown(KeyCode.Keypad2)||Input.GetKeyDown(KeyCode.Alpha2)) { 
            birdsEye.enabled = false; 
            earth.enabled = true;
            current = earth;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            current.orthographicSize -= speed * Time.deltaTime * multiplier;
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            current.orthographicSize += speed * Time.deltaTime * multiplier;
        }
        current.orthographicSize = Mathf.Clamp(current.orthographicSize, 1f, 2000f);
        if (birdsEye.enabled)
        {
            if (Input.GetKey(KeyCode.A))
                current.transform.position -= new Vector3(speed * Time.deltaTime * multiplier, 0, 0);
            if (Input.GetKey(KeyCode.D))
                current.transform.position += new Vector3(speed * Time.deltaTime * multiplier, 0, 0);
            if (Input.GetKey(KeyCode.W))
                current.transform.position += new Vector3(0, 0, speed * Time.deltaTime * multiplier);
            if (Input.GetKey(KeyCode.S))
                current.transform.position -= new Vector3(0, 0, speed * Time.deltaTime * multiplier);
        }

        if (Input.GetKey(KeyCode.R))
            {
                earth.transform.position = earthStart;
                earth.orthographicSize = earthSize;
                birdsEye.transform.position = birdStart;
                birdsEye.orthographicSize = birdSize;
                earth.enabled = false;
                birdsEye.enabled = true;
                current = birdsEye;
        }
    }
}
