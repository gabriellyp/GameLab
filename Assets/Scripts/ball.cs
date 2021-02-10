using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public bool isFlat = true;
    Rigidbody rb;
    public float speed = 0.3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector3 tilt = Input.acceleration;
        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * (tilt*speed);
        rb.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.clear);
    }
}
