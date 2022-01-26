using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourMoveAnimation : MonoBehaviour
{
    private float checkRotation = 0f;
    private GeneralMovement gMove;
    private Animator anim;

    void Start()
    {
        gMove = GetComponent<GeneralMovement>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        MoveAnimation();
    }

    private void MoveAnimation()
    {
        if (gMove.directionMagnitude() >= 0.1)
        {
            Debug.Log("imMoving");
            Debug.Log(transform.localRotation.y);
        }
    }
}
