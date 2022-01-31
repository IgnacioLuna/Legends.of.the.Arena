using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorMovementSkill : GeneralMovementSkill
{
    [SerializeField] protected float dashSpeed;
    [SerializeField] protected float dashTime;
    protected GeneralMovement movement;
    protected Vector3 dashDirection;
    //protected float startTime;
    //protected float totalDashTime = 0f;
    // protected bool isDash;

    protected override void Start()
    {
        base.Start();
        movement = GetComponent<GeneralMovement>();
    }

    protected override void Update()
    {
        if (view.IsMine)
        {
            if (Time.time >= nextActivation)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    dashDirection = movement.MoveDirection().normalized;
                    Debug.Log(dashDirection);
                    StartCoroutine(Dash());
                    nextActivation = Time.time + cooldown;
                }
            }
        }
    }

    protected IEnumerator Dash()
    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.position += dashDirection * dashSpeed * Time.deltaTime;

            yield return null;
        }
    }
     /*
    protected override void MovementSkill()
    {
        base.MovementSkill();
        Vector3 direction = movement.MoveDirection().normalized;
        while (isDash)
        {
            transform.position += direction * dashSpeed * Time.deltaTime;
            if (Time.time >= totalDashTime)
                isDash = false;
        }
    }
     */
}
