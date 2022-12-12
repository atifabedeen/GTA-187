using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathCollider : MonoBehaviour
{
    public Text mathQ;
    public GameObject box;
    void OnTriggerEnter(){
        Debug.Log("pee");
        box.SetActive(false);
        mathQ.text = "What is 5 * 12?"; 
    }
}
