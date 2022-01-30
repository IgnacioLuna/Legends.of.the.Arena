using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBasicAttack : MonoBehaviour
{
    [SerializeField] protected float cooldown;
    protected float nextActivation = 0f;

    protected void Update()
    {
        if (Time.time >= nextActivation)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                BasicAttack();
                nextActivation = Time.time + cooldown;
            }
        }
    }

    protected virtual void BasicAttack()
    {
        Debug.Log("Im Attacking");
    }
}
