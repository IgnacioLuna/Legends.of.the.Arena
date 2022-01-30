using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBasicAttack : GeneralBasicAttack
{
    [SerializeField] protected TrailRenderer trail;
    [SerializeField] private Collider col;
    protected Animator anim;
    protected bool state = false;

    protected void Start()
    {
        anim = GetComponent<Animator>();
    }

    protected override void BasicAttack()
    {
        base.BasicAttack();
        anim.SetTrigger("BasicAttack");
    }

    private void Switch()
    {
        state = !state;
        col.enabled = state;
        trail.enabled = state;
    }
}
