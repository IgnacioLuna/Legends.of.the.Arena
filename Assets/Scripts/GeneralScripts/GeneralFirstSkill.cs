using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralFirstSkill : MonoBehaviour
{
    [SerializeField] protected float cooldown;
    protected float nextActivation = 0f;
    
    protected virtual void Update()
    {
        if (Time.time >= nextActivation)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                FirstSkill();
                nextActivation = Time.time + cooldown;
            }
        }
    }

    protected virtual void FirstSkill()
    {
        Debug.Log("Im FirstSkilling");
    }
}
