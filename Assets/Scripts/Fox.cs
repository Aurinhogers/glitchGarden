using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Defender>())
        {
            if (collision.GetComponent<Gravestone>())
            {
                GetComponent<Animator>().SetTrigger("jumpTrigger");
                return;
            }

            GetComponent<Attacker>().Attack(collision.gameObject, damage);
        }
    }
}
