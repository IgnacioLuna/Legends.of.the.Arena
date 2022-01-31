using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashCollisionDetection : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DummyStats>() == null)
            return;
        other.GetComponent<DummyStats>().GetDamage(damage);
    }
}
