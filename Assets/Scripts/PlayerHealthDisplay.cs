using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    GameStatus gameStatus;
    Text starText;


    void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        starText = GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        starText.text = gameStatus.GetHealth().ToString();
    }
}
