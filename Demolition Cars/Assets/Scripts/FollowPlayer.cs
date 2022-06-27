using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    private bool cameraPos = true;
    public bool isPlayerOne = true;

    void Update()
    {
        if (isPlayerOne)
        {
            if (Input.GetKeyDown("c"))
                cameraPos = !cameraPos;
        }
        else
        {
            if (Input.GetKeyDown("v"))
                cameraPos = !cameraPos;
        }
    }

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2.01f, 1.59f);

    // Update is called once per frame
    void LateUpdate()
    {


        if (cameraPos)
        {
            // offset camera behind player
            transform.position = player.transform.position + offset;
        }
        else
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
