using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public TextMeshProUGUI gameOver;
    public Button restartButton;
    public GameObject titleScreen;

    private int secondsLeft = 20;
    public bool takingAway = false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    //Timer if statement for display
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "Time left 00:0" + secondsLeft;
        }
        else
        {


            textDisplay.GetComponent<Text>().text = "Time left 00:" + secondsLeft;
        }
        takingAway = false;
        //if time if finished show restart and game over
        if(secondsLeft < 1)
        {
                gameOver.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
        //if 5 seconds have passed the title screen will disappear
        if(secondsLeft < 16)
        {
            titleScreen.gameObject.SetActive(false);
        }
        
    }
    //
    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
    }

   
    
}
