using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerControll : MonoBehaviour
{
    private float speed = 5.0f;
    public float horizontalInput;
    public float forwardInput;
    public float startBoundary = 87.0f;
    public float endBoundary = 34.0f;
    public TextMeshProUGUI gameOver;
    private int secondsLeft = 12;
    public bool takingAway = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        //Move Player 
        if (transform.position.x > startBoundary)
        {
            transform.position = new Vector3(startBoundary, transform.position.y, transform.position.z);
        }
        if(transform.position.z < endBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, endBoundary);
        }
        //Move player Horizonticly
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //Move player Verticaly
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //IF Player reaches finish line show game over
        if (transform.position.z < 35)
        {

            gameOver.gameObject.SetActive(true);
                }
    }
    //Timer
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if(secondsLeft < 1)
        {
            
        }
    }


    }
