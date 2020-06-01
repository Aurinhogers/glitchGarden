using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 50;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Attacker>() && collision.GetComponent<Health>())
        {
            collision.GetComponent<Health>().DealDamage(damage);
        }
    }
}
