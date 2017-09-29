using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Policial1 : MonoBehaviour {

    public float velocidade;
    public GameObject Player;
    public GameObject PosicaoInicial;
    public estadoPolicia currState;
    public float MaxX = 18.28f;
    public float MinX = 9.23f;
    public float MaxY = 6.21f;
    public float MinY = 0.52f;
    public enum estadoPolicia
    {
        viuPlayer = 0,
        naoViuPlayer = 1,
        perdiPlayer = 2
    }

    // Use this for initialization
    void Start()
    {

        currState = estadoPolicia.naoViuPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (currState == estadoPolicia.naoViuPlayer)
        {

            if (transform.position.x <= MinX)
            {
                transform.Translate(0, velocidade * Time.deltaTime, 0);
            }
            if (transform.position.x >= MaxX)
            {
                transform.Translate(0, -velocidade * Time.deltaTime, 0);
            }
            if (transform.position.y <= MinY)
            {
                transform.Translate(-velocidade * Time.deltaTime, 0, 0);
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (transform.position.y >= MaxY)
            {
                transform.Translate(velocidade * Time.deltaTime, 0, 0);
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else if (currState == estadoPolicia.viuPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Mathf.Abs(velocidade * Time.deltaTime));
            if (Player.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (Player.transform.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

        }
        else if (currState == estadoPolicia.perdiPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, PosicaoInicial.transform.position, Mathf.Abs(velocidade * Time.deltaTime));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform == PosicaoInicial.transform)
        {
            currState = estadoPolicia.naoViuPlayer;
        }
    }

}

