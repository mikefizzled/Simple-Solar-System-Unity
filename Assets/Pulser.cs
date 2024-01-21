using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(Mathf.Sin(Time.time), Mathf.Sin(Time.time), Mathf.Sin(Time.time));
    }
}
