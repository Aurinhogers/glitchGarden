using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerArray;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        };
    }

    private void SpawnAttacker()
    {
        Attacker prefabAttacker = attackerArray[UnityEngine.Random.Range(0, attackerArray.Length)];
        Spawn(prefabAttacker);
    }

    private void Spawn(Attacker prefabAttacker)
    {
        Attacker attacker = Instantiate
            (prefabAttacker, transform.position, transform.rotation)
            as Attacker;

        attacker.transform.parent = transform;
    }
}
