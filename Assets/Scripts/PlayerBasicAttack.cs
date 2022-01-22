using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicAttack : MonoBehaviour
{
    [SerializeField] private float attackRate;
    private float nextAttackTime = 0f;

    void Update()
    {
        //Debug.Log(Time.time);

        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                BasicAttack();
              
                nextAttackTime = Time.time + attackRate;
            }
        }
    }

    private void BasicAttack()
    {
        Debug.Log("Im Attacking");
    }
}
