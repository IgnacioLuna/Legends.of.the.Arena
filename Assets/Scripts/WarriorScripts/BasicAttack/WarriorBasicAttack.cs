using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorBasicAttack : GeneralBasicAttack
{
    [SerializeField] protected ParticleSystem trail;
    [SerializeField] private Collider col;
    protected Animator anim;
    protected bool state = false;

    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }

    protected override void BasicAttack()
    {
        base.BasicAttack();
        anim.SetTrigger("BasicAttack");
    }

    protected void Switch()
    {
        state = !state;
        col.enabled = state;
    }

    protected void TrailPlay()
    {
        trail.Play();
    }

    protected void TrailPause()
    {
        trail.Stop();
    }
}
