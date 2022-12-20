using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midWayTriggerAI : MonoBehaviour
{
    public GameObject lapEndAi;
    public GameObject halfTrigAi;
    public void OnTriggerEnter(Collider coll) {
         if(coll.gameObject.tag == "aicar"){
                lapEndAi.SetActive(true);
                halfTrigAi.SetActive(false);
         }

    }
}
