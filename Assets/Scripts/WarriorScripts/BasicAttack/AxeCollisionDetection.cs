using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DummyStats>() == null)
            return;
        other.GetComponent<DummyStats>().GetDamage(20);
    }
}
