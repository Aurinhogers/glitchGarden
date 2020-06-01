using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,5f)][SerializeField] float currentSpeed = 1f;
    GameObject currentTarget;
    int currentDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
       
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetSpeed( float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target, int damage)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
        currentDamage = damage;
    }

    public void StrikeCurrentTarget()
    {
        
        if (!currentTarget) {
            return;
        }

        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(currentDamage);
        }
    }
}
    