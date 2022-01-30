using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovementSkill : MonoBehaviour
{
    [SerializeField] protected float cooldown;
    protected float nextActivation = 0f;

    protected virtual void Update()
    {
        if (Time.time >= nextActivation)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                MovementSkill();
                nextActivation = Time.time + cooldown;
            }
        }
    }

    protected virtual void MovementSkill()
    {
        Debug.Log("Im MovementSkilling");
    }
}
