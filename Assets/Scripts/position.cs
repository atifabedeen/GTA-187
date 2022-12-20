using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class position : MonoBehaviour
{
    public Text hasWon;
    void Update()
    {
        if(lapFinishAi.hasAiWon) {
            hasWon.text = "You finished 2nd! :(";
        }
        else {
            hasWon.text = "You finished 1st! :)";
        }
    }
}
