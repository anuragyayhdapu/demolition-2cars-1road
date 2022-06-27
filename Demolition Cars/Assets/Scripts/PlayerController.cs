using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;

    public bool isPlayerOne = true;

    // Update is called once per frame
    void Update()
    {
        // Get player input
        if (isPlayerOne)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal2");
            forwardInput = Input.GetAxis("Vertical2");
        }


        // move & turn vehicle 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
