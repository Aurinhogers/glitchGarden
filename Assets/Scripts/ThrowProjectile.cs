using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowProjectile : MonoBehaviour
{
    [SerializeField] float throwSpeed = 5f;
    [SerializeField] float speedOfSpin = -200f;
    [SerializeField] int damage = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * throwSpeed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, speedOfSpin * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();

        if(health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);  
        }
    }
}
