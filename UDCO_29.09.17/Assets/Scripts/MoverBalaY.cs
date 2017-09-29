using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverbalaY : MonoBehaviour
{

    public float vel;

    void Start()
    {
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * vel;
    }
}
