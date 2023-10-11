using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliosionDetect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destroy this game object
        Destroy(other.gameObject); // Destroy the other gameobject it hits
    }
}
