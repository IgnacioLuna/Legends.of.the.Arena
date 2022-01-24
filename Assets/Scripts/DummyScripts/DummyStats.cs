using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyStats : MonoBehaviour
{
    [SerializeField] private float life;
    [SerializeField] private float healCooldown;
    private float timeToHeal = 0;
    private bool canHeal;

    private void Update()
    {
        if (canHeal || life <= 0)
            Heal();

        if (timeToHeal >= healCooldown)
            canHeal = true;
        else
            timeToHeal += Time.deltaTime;
    }

    public void GetDamage(float damage)
    {
        life -= damage;
        canHeal = false;
        timeToHeal = 0f;
        Debug.Log(life);
    }

    private void Heal()
    {
        life = 500f;
    }
}
