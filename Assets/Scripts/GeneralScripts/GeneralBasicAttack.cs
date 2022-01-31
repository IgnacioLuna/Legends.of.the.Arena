using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GeneralBasicAttack : MonoBehaviour
{
    [SerializeField] protected float cooldown;
    protected PhotonView view;
    protected float nextActivation = 0f;

    protected virtual void Start()
    {
        view = GetComponent<PhotonView>();    
    }

    protected void Update()
    {
        if (view.IsMine)
        {
            if (Time.time >= nextActivation)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    BasicAttack();
                    nextActivation = Time.time + cooldown;
                }
            }
        }
    }

    protected virtual void BasicAttack()
    {
        Debug.Log("Im Attacking");
    }
}
