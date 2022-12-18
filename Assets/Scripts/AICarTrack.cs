using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTrack : MonoBehaviour
{
    public GameObject Marker;

    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint4;
    public GameObject waypoint5;
    public GameObject waypoint6;
    public GameObject waypoint7;
    public GameObject waypoint8;
    public GameObject waypoint9;
    public GameObject waypoint3i;
    public GameObject waypoint3ii;
    public GameObject waypoint3iii;
    public GameObject waypoint3iv;
    public GameObject waypoint3v;

    public int marktracker;
    void Update()
    {
        if (marktracker == 0){
            Marker.transform.position = waypoint1.transform.position;
        }
        if (marktracker == 2){
            Marker.transform.position = waypoint2.transform.position;
        }
        if (marktracker == 1){
            Marker.transform.position = waypoint3iv.transform.position;
        }
        if (marktracker == 3){
            Marker.transform.position = waypoint3.transform.position;
        }
        if (marktracker == 4){
            Marker.transform.position = waypoint3i.transform.position;
        }
        if (marktracker == 5){
            Marker.transform.position = waypoint3ii.transform.position;
        }
        if (marktracker == 6){
            Marker.transform.position = waypoint3iii.transform.position;
        }
        if (marktracker == 7){
            Marker.transform.position = waypoint4.transform.position;
        }
        if (marktracker == 8){
            Marker.transform.position = waypoint3v.transform.position;
        }
        if (marktracker == 9){
            Marker.transform.position = waypoint5.transform.position;
        }
        if (marktracker == 10){
            Marker.transform.position = waypoint6.transform.position;
        }
        if (marktracker == 11){
            Marker.transform.position = waypoint7.transform.position;
        }
        if (marktracker == 12){
            Marker.transform.position = waypoint8.transform.position;
        }
        if (marktracker == 13){
            Marker.transform.position = waypoint9.transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider coll){
        if (coll.gameObject.tag == "aicar"){
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker += 1;
            if(marktracker == 14)
                marktracker = 0;
        }
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;

    }
}
