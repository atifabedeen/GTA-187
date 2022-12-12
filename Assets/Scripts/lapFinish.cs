using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class lapFinish : MonoBehaviour
{
    public GameObject lapFinishTrigger;
    public GameObject midway;

    public GameObject bestMill;
    public GameObject bestMin;
    public GameObject bestSec;
    
   public void OnTriggerEnter() {
        if(LapTimeController.secCount <= 9) {
            bestSec.GetComponent<Text>().text = "0" + LapTimeController.secCount + ".";
        }
        else{
            bestSec.GetComponent<Text>().text = "" + LapTimeController.secCount + ".";
        }
        if(LapTimeController.minCount <= 9) {
            bestMin.GetComponent<Text>().text = "0" + LapTimeController.minCount + ":";
        }
        else{
            bestMin.GetComponent<Text>().text = "" + LapTimeController.minCount + ":";
        }        
        bestMill.GetComponent<Text>().text = "" + LapTimeController.millCount;

        LapTimeController.minCount = 0;
        LapTimeController.secCount = 0;
        LapTimeController.millCount = 0;

        midway.SetActive(true);
        lapFinishTrigger.SetActive(false);
   }


}
