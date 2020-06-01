using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] GameObject deathVFX;
    bool isDying = false;
    public float fade = 1f;

    public void DealDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
        }
    }

    private void Update()
    {
        if (isDying)
        {
            fade -= Time.deltaTime;

            if(fade <= 0f)
            {
                fade = 0f;
                Destroy(gameObject);
            }

            this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().material.SetFloat("_Fade", fade);
        }
    }

    private void TriggerDeathVFX()
    {

        isDying = true;

    }
}
