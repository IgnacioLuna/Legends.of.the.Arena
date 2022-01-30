using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOff : MonoBehaviour
{
    private BoxCollider smashCollider;

    private void Start()
    {
        smashCollider = GetComponent<BoxCollider>();
    }
    private void DisableCollider()
    {
        smashCollider.enabled = false;
    }
}
