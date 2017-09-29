using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CachorroX : MonoBehaviour {
    public float vel;
    public bool olhandoDireita;
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;
	void Start () {
		
	}
    void Flip()
    {
        olhandoDireita = !olhandoDireita;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-vel, 0, 0);

        if (transform.position.x <= MaxX)
        {
            Flip();
            olhandoDireita = true;
            vel *= -1;
        }

        if (transform.position.x >= MinX)
        {
            Flip();
            olhandoDireita = false;
            vel *= -1;
        }
    }
}
