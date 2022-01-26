using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBasicAttack : GeneralBasicAttack
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    protected override void BasicAttack()
    {
        base.BasicAttack();
        anim.SetTrigger("Attack");
    }
}
