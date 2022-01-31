using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorFirstSkill : GeneralFirstSkill
{
    [SerializeField] protected GameObject firstSkill;
    [SerializeField] protected GameObject smashCollider;
    [SerializeField] protected Transform particlePosition;
    protected Animator anim;
    protected GeneralMovement movement;
    protected GeneralLookToMouse rotation;
    protected GeneralBasicAttack basicAttack;
    protected Vector3 pointToLook;
    protected bool state = true;
    protected bool colliderMove = false;

    protected override void Start()
    {
        base.Start();
        firstSkill = GameObject.Find("SmashAttack");
        anim = GetComponent<Animator>();
        movement = GetComponent<GeneralMovement>();
        rotation = GetComponent<GeneralLookToMouse>();
        basicAttack = GetComponent<GeneralBasicAttack>();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void FirstSkill()
    {
        base.FirstSkill();
        anim.SetTrigger("FirstSkill");
    }

    protected  void StopMove()
    {
        state = !state;
        movement.enabled = state;
        rotation.enabled = state;
        basicAttack.enabled = state;
    }

    protected void PlayParticle()
    {
        pointToLook = rotation.GetPointToLook();
        firstSkill.transform.position = particlePosition.position;
        firstSkill.transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        firstSkill.GetComponent<ParticleSystem>().Play();
        smashCollider.GetComponent<BoxCollider>().enabled = true;
        smashCollider.GetComponent<Animator>().SetTrigger("Smash");
    }
}
