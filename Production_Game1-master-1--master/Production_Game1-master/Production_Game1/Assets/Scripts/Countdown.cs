using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    float currentTime = 0f;
    float startingTime = 60f;

    [SerializeField] Text countdownText;

	// Use this for initialization
	void Start () {
        currentTime = startingTime;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0){

            LoseMenu.GameIsLost = true;
            currentTime = 0;
        }
	}
}
