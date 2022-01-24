using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
}
