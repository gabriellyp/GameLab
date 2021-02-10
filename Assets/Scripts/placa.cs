using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa : MonoBehaviour
{
    public int value = 10;
    public GameObject explosionPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // destroy after collection
            Destroy(gameObject);
        }

    }
}
