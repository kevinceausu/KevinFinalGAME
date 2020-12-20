using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer1 : MonoBehaviour
{
    public GameObject textDisplay1;
    public TextMeshProUGUI gameOver1;
    public Button restartButton1;
    public GameObject titleScreen1;

    private int secondsLeft1 = 15;
    public bool takingAway1 = false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay1.GetComponent<Text>().text = "00:" + secondsLeft1;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway1 == false && secondsLeft1 > 0)
        {
            StartCoroutine(TimerTake1());
        }
    }
    //Timer if statement for Display
    IEnumerator TimerTake1()
    {
        takingAway1 = true;
        yield return new WaitForSeconds(1);
        secondsLeft1 -= 1;
        if (secondsLeft1 < 10)
        {
            textDisplay1.GetComponent<Text>().text = "Time left 00:0" + secondsLeft1;
        }
        else
        {


            textDisplay1.GetComponent<Text>().text = "Time left 00:" + secondsLeft1;
        }
        takingAway1 = false;

        if (secondsLeft1 < 1)
        {
            gameOver1.gameObject.SetActive(true);
            restartButton1.gameObject.SetActive(true);
        }

    }
    //When game starts title screen disappears
    public void StartGame()
    {
        titleScreen1.gameObject.SetActive(false);
    }

    


}