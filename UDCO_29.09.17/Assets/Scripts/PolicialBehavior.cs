using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicialBehavior : MonoBehaviour {
    public float velocidade;
    public bool olhandoDireita;
    public float posMax;
    public float posMin;
    GameObject Player;
    public GameObject PosicaoInicial;
    private bool Vira = false;
    public estadoPolicia currState;

    public enum estadoPolicia
    {
        viuPlayer = 0,
        naoViuPlayer = 1,
        perdiPlayer = 2
    }

	// Use this for initialization
	void Start () {
        
        currState = estadoPolicia.naoViuPlayer;
        Player = GameObject.FindGameObjectWithTag("Player");


    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(currState);
        if (currState == estadoPolicia.naoViuPlayer)
        {
            transform.Translate(0, velocidade*Time.deltaTime, 0);

            if (transform.position.y >= posMin|| transform.position.y <= posMax)
            {
                velocidade *= -1;
            }            
        }
        else if(currState == estadoPolicia.viuPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position,Mathf.Abs( velocidade * Time.deltaTime));
            if (Player.transform.position.x < transform.position.x)
            {
                
                olhandoDireita = true;
            }
           else if(Player.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                olhandoDireita = false;
            }

        }
        else if (currState == estadoPolicia.perdiPlayer)
        { 
            transform.position = Vector3.MoveTowards(transform.position, PosicaoInicial.transform.position, Mathf.Abs(velocidade * Time.deltaTime));
            transform.localScale = new Vector3(-1, 1, 1);
        }
      
    }
}
