using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(orbiting) { 
            transform.Rotate(rotation);
        }

        if(Input.GetKeyDown(KeyCode.Space)) { 
            orbiting = !orbiting;
        }
        
    }
    public Vector3 rotation = new Vector3(0, 0.5f, 0);
    public bool orbiting = true;
}
