using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class PlayerControl2 : MonoBehaviour
{
    private float speed = 5.0f;
    public float horizontalInput;
    public float forwardInput;
    public float startBoundary = 87.0f;
    public float endBoundary = 34.0f;
    private AudioSource win;
    public Button restart;
    public AudioClip winSound;
    public TextMeshProUGUI gameOver;
    // Start is called before the first frame update
    void Start()
    {
        win = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    //Move the player
    void Update()
    {
        //Be able to move the player
        if(transform.position.x > startBoundary)
        {
            transform.position = new Vector3(startBoundary, transform.position.y, transform.position.z);
        }
        if(transform.position.z < endBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, endBoundary);
        }
        //Move player horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Move player vertical
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //When finish line is reached play sound, show restart button and display game over message
        if (transform.position.x < 40)
        {

            gameOver.gameObject.SetActive(true);
            win.PlayOneShot(winSound, 0.05f);
            restart.gameObject.SetActive(true);

        }



    }
 
}
