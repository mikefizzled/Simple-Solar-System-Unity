using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform orbitCenter;
    [Tooltip("Orbital period in Earth years")]
    public float orbitalPeriod = 1f;
    public bool orbiting = true;

    void Update()
    {
        if (orbiting && orbitCenter != null)
        {
            float orbitSpeed = 50f / orbitalPeriod; // 50f = global speed scaler
            transform.RotateAround(orbitCenter.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            orbiting = !orbiting;
    }
}
