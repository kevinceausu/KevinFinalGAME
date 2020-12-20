using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController3 : MonoBehaviour
{
    private float speed = 5.0f;
    public float horizontalInput;
    public float forwardInput;
    public float startBoundary = 87.0f;
    public float endBoundary = 18.0f;
    public TextMeshProUGUI winner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > startBoundary)
        {
            transform.position = new Vector3(startBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.z < endBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, endBoundary);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        if (transform.position.z < 23)
        {

            winner.gameObject.SetActive(true);
        }


    }
    
}
