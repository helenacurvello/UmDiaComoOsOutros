using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Player")
        {
            PolicialBehavior policialBehaviour = transform.parent.GetComponent<PolicialBehavior>();
            if( policialBehaviour != null )
                policialBehaviour.currState = PolicialBehavior.estadoPolicia.viuPlayer;

            Policial1 policial1 = transform.parent.GetComponent<Policial1>();
            if( policial1 != null )
                policial1.currState = Policial1.estadoPolicia.viuPlayer;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PolicialBehavior policialBeviour = transform.parent.GetComponent<PolicialBehavior>();
            if(policialBeviour != null )
            policialBeviour.currState = PolicialBehavior.estadoPolicia.perdiPlayer;

            Policial1 policial1 = transform.parent.GetComponent<Policial1>();
            if(policial1 != null )
            policial1.currState = Policial1.estadoPolicia.perdiPlayer;
        }
    }
}
