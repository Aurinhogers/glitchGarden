using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    public int damage = 10;

    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        GameObject otherObject = otherCollision.gameObject;

        if(otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject, damage);
        }
    }
}
