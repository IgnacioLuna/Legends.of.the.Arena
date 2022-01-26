using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 direction;
    private Animator anim;
    //private Rigidbody rb;


    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //Debug.Log(transform.localPosition);
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0f, vertical);
        Vector3 dirNorm = direction.normalized;
        anim.SetFloat("RunForward", direction.magnitude);

        //if (horizontal == 0 && vertical == 0)
        //    rb.velocity = Vector3.zero;

        if (direction.magnitude >= 0.1f)
            transform.position += dirNorm * speed * Time.deltaTime;
    }

    public float directionMagnitude()
    {
        return direction.magnitude;
    }
}
