using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 10f, 0);  // degrees per second
    public bool orbiting = true;

    void Update()
    {
        if (orbiting)
        {
            transform.Rotate(rotation * Time.deltaTime * 100f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            orbiting = !orbiting;
        }
    }
}
