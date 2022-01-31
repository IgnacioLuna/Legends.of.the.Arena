using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Animator anim;
    protected PhotonView view;
    protected Vector3 direction;
    //private Rigidbody rb;


    protected void Start()
    {
        //rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        view = GetComponent<PhotonView>();
    }

    protected void Update()
    {
        if (view.IsMine)
        {
            MoveDirection();
            Move(MoveDirection().normalized, speed);
        }
    }

    public void Move(Vector3 moveDir, float speed)
    {
        if (direction.magnitude >= 0.1f)
        {
            //rb.velocity = moveDir * speed;
            transform.position += moveDir * speed * Time.deltaTime;
        }
        anim.SetFloat("RunForward", direction.magnitude);
    }

    public Vector3 MoveDirection()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        return direction = new Vector3(horizontal, 0f, vertical);
    }

    public float directionMagnitude()
    {
        return direction.magnitude;
    }
}
