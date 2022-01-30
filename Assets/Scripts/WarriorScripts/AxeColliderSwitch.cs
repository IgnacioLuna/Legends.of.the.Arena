using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeColliderSwitch : MonoBehaviour
{
    [SerializeField] private Collider col;
    private bool state = false;

    private void Attack()
    {
        state = !state;
        col.enabled = state;
    }
}
