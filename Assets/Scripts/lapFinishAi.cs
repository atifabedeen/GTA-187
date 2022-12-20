using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class lapFinishAi : MonoBehaviour
{
    
    private int ailaps = 1;
    public static bool hasAiWon = false;
    public GameObject lapFinishTriggerAI;
    public GameObject lapMidTriggerAI;

    public void OnTriggerEnter(Collider coll) {
         if(coll.gameObject.tag == "aicar"){
            ailaps += 1;
            if (ailaps > lapFinish.totalLaps){
                hasAiWon = true;
            }
            lapFinishTriggerAI.SetActive(false);
            lapMidTriggerAI.SetActive(true);

         }
    }

}
