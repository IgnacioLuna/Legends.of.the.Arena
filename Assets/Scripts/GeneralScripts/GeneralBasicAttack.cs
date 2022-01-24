using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBasicAttack : MonoBehaviour
{
    [SerializeField] protected float attackRate;
    protected float nextAttackTime = 0f;

    protected void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                BasicAttack();
                nextAttackTime = Time.time + attackRate;
            }
        }
    }

    protected virtual void BasicAttack()
    {
        Debug.Log("Im Attacking");
    }
}
