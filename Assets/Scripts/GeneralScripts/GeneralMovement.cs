using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 direction;
    //private Rigidbody rb;


    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0f, vertical).normalized;

        //if (horizontal == 0 && vertical == 0)
        //    rb.velocity = Vector3.zero;

        if (direction.magnitude >= 0.1f)
            transform.position += direction * speed * Time.deltaTime;
    }
}