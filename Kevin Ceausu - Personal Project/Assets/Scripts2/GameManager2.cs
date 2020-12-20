using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public TextMeshProUGUI gameOver;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //When game is over show restart button and game over text
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(true);


    }
    //Go back to the first level
    public void RestartGame()
    {

        SceneManager.LoadScene(0);
    }




}
