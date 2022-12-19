using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

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
    public int totalLaps = 3;

    private int ailaps = 1;
    public static bool hasAiWon = false;

    public GameObject bestMill;
    public GameObject bestMin;
    public GameObject bestSec;

    public void start() {
        hasAiWon = false;
    }
    
   public void OnTriggerEnter(Collider coll) {
    if(coll.gameObject.tag != "aicar"){
        nLaps += 1;
        if(nLaps > totalLaps) {
            SceneManager.LoadScene("EndScene");
        }
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
    else {
        ailaps += 1;
        if (ailaps > totalLaps){
            hasAiWon = true;
        }
    }
   }
}
