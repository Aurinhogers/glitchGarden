﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject gun;
    [SerializeField] ThrowProjectile projectile;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("isAttacking", true);
         
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
                return;
            }
        } 
    }

    private bool IsAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        } 

        return true;
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
