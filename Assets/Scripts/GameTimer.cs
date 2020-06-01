using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("In seconds")]
    [SerializeField] float gameTime = 60f;

    Slider gameTimeSlider;


    // Start is called before the first frame update
    void Start()
    {
        gameTimeSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        gameTimeSlider.value = Time.timeSinceLevelLoad / gameTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= gameTime);
        if (timerFinished)
        {
            Debug.Log("level timer finished");
        }
    }
}
