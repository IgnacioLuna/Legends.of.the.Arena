using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorMovementSkill : GeneralMovementSkill
{
    [SerializeField] protected float dashSpeed;
    [SerializeField] protected float dashTime;
    protected GeneralMovement movement;

    protected void Start()
    {
        movement = GetComponent<GeneralMovement>();
    }

    protected override void MovementSkill()
    {
        base.MovementSkill();
        if (Time.time - dashTime)
    }
}
