using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBasicAttack : GeneralBasicAttack
{
    [SerializeField] private Animator swordAnim;

    protected override void BasicAttack()
    {
        base.BasicAttack();
        swordAnim.SetTrigger("Attack");
    }
}
