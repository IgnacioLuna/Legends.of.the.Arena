using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GeneralMovementSkill : MonoBehaviour
{
    [SerializeField] protected float cooldown;
    protected PhotonView view;
    protected float nextActivation = 0f;

    protected virtual void Start()
    {
        view = GetComponent<PhotonView>();
    }

    protected virtual void Update()
    {
        if (view.IsMine)
        {
            if (Time.time >= nextActivation)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    MovementSkill();
                    nextActivation = Time.time + cooldown;
                }
            }
        }
    }

    protected virtual void MovementSkill()
    {
        Debug.Log("Im MovementSkilling");
    }
}
