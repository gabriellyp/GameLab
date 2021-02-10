using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour
{
    public int value = 10;
    public GameObject explosionPrefab;

    void OnTriggerEnter(Collider other)
    {
        
            // destroy after collection
            Destroy(gameObject);
       
    }
    private void Update()
    {
        transform.Rotate(0,35*Time.deltaTime,0);
    }
}
