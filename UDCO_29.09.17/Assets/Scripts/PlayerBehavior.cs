using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerBehavior : MonoBehaviour {

    public Rigidbody2D playerRigidbody;
      
      public float velocidade;
      public int pontos;
      public bool correndo;
      public Text theText;
    void Start ()
      {

        pontos = 0;
	  }
   
    void FixedUpdate ()
    {

        theText.GetComponent<Text>().text = "pontos: " + pontos;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Animator>().SetFloat("speed", 0.2f);

            Vector2 pos = playerRigidbody.position;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                pos += new Vector2(velocidade, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pos += new Vector2(-velocidade, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                pos += new Vector2(0, velocidade);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                pos += new Vector2(0, -velocidade);
            }

            playerRigidbody.MovePosition(pos);

        }
        else GetComponent<Animator>().SetFloat("speed", 0.0f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            correndo = true;
        }
        else correndo = false;
        if (correndo)
        {
            //velocidade += 0.05f;
        }
        //pontos
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "policial")
        {
            SceneManager.LoadScene("preso");
        }
        if (col.gameObject.tag == "mato")
        {
            SceneManager.LoadScene("vitoria");
        }
    
        if(col.gameObject.tag == "bala")
            {
                SceneManager.LoadScene("GameOver");
            }
        if(col.gameObject.tag == "crianca")
        {

          
            pontos += 1;
            Destroy(col.gameObject);
        }


        }

    }

