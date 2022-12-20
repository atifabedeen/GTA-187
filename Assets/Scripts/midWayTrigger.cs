using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midWayTrigger : MonoBehaviour
{
    public GameObject lapEnd;
    public GameObject halfTrig;
    public void OnTriggerEnter(Collider coll) {
         if(coll.gameObject.tag != "aicar"){
                lapEnd.SetActive(true);
                halfTrig.SetActive(false);
         }

    }
}
