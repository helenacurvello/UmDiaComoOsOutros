using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    //private Vector3 offset;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        //   offset = transform.position - player.transform.position;
    }
    void Update()
    {

       // if (player.transform.position.x >= 7.87f && transform.position.x < 52.32f)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

            //transform.position = player.transform.position + offset;
        }
        /*
        if(transform.position.x >= 52.32f && transform.position.y > -15f)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }

        if(transform.position.y < -15f)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        */
    }
}
