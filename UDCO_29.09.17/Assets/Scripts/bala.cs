using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour {

    public float vel;
    
	void Start ()
    {        
        Destroy(this.gameObject, 2);	        
	}
	
	// Update is called once per frame
	void Update ()
    {        
        transform.position += Vector3.left * vel;
    }
}
