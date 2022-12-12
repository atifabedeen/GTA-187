using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeController : MonoBehaviour
{
    public static int minCount;
    public static int secCount;
    public static float millCount;
    public static string millDisp;
    public GameObject secText;
    public GameObject millText;
    public GameObject minText;

    void Update()
    {
        millCount += Time.deltaTime*10;
        millDisp = millCount.ToString("F0");
        millText.GetComponent<Text>().text = "" + millDisp;

        if(millCount >= 10) {
            millCount = 0;
            secCount += 1;
        }

        if(secCount <= 9) {
            secText.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else {
            secText.GetComponent<Text>().text = "" + secCount + ".";
        }

        if(secCount >= 60) {
            secCount = 0;
            minCount += 1;
        }
        if(minCount <= 9) {
            minText.GetComponent<Text>().text = "0" + minCount + ":";
        }
        else {
            minText.GetComponent<Text>().text = "" + minCount + ":";
        }
    }
}
