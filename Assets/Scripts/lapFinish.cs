using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class lapFinish : MonoBehaviour
{
    public GameObject lapFinishTrigger;
    public GameObject midway;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;
    public GameObject qBox1;
    public GameObject qBox2;
    public GameObject qBox3;
    public Text lapText;
    public int nLaps = 1;
    private int totalLaps = 3;

    public GameObject bestMill;
    public GameObject bestMin;
    public GameObject bestSec;
    
   public void OnTriggerEnter() {
        nLaps += 1;
        //Check here for game over
        lapText.text = "LAP: " + nLaps + "/" + totalLaps;
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
        box1.SetActive(true);
        box2.SetActive(true);
        box3.SetActive(true);
        box4.SetActive(true);
        box5.SetActive(true);
        box6.SetActive(true);
        qBox1.SetActive(true);
        qBox2.SetActive(true);
        qBox3.SetActive(true);


   }


}
