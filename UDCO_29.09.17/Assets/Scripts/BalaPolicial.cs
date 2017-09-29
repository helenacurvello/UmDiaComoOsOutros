using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalaPolicial : MonoBehaviour {
    
    public GameObject bala;
    private GameObject bulletInstance;
    public GameObject Gerador;
    private bool Onetime;
    private float tempo;

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ((int)Time.time % 2 == 0)
        {
            if (Onetime)
            {
                Atirar();
                Onetime = false;
            }
        }
        else Onetime = true;
    }
    private void Atirar()
    {        
        bulletInstance = Instantiate(bala, Gerador.transform.position, Quaternion.identity);

        if (this.transform.localScale.x > 0) bulletInstance.GetComponent<bala>().vel = -0.2f;
        else bulletInstance.GetComponent<bala>().vel = 0.2f;
    }
}

    
