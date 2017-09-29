using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarroPolicia : MonoBehaviour
{

    public float velocidade;
    public bool olhandoDireita;

    // Use this for initialization
    void Start()
    {
        
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
        transform.Translate(velocidade * Time.deltaTime, 0, 0);
        if (transform.position.x >= 6.06f || transform.position.x <= 1.0f)
       {
            velocidade *= -1;
            Flip();
            olhandoDireita = true;
        }
        }
    }

