using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midWayTrigger : MonoBehaviour
{
    public GameObject lapEnd;
    public GameObject halfTrig;
    public void OnTriggerEnter() {
        lapEnd.SetActive(true);
        halfTrig.SetActive(false);
    }
}
