using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [SerializeField] int playerHealth = 100;
    [SerializeField] int attackerReduceScore = 10;
    [SerializeField] AudioClip gameOverAudio;

    public int GetHealth()
    {
        return playerHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth -= attackerReduceScore;
        if(playerHealth <= 0)
        {
            FindObjectOfType<SceneLoader>().LoadNextScene();
        }
    }

}
