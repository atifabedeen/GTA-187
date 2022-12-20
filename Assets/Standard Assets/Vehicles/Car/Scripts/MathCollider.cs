using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathCollider : MonoBehaviour
{
    public Text mathQ;
    public GameObject box;
    private char[] operators = {'+', '-', '*'};
    private int leftNum;
    private int rightNum;
    private char op;
    public static int wrongAns;
    public static int rightAns;

    void OnTriggerEnter(Collider coll){
        if (coll.gameObject.tag != "aicar"){
            box.SetActive(false);
            generateExpression();
            mathQ.text = "What is " + leftNum + " " + op + " " + rightNum + "?"; 
        }
    }

    private void generateExpression() {
        leftNum = Random.Range(0,21);
        rightNum = Random.Range(0,21);
        int idx = Random.Range(0,3);
        op = operators[idx];
        switch(op) {
            case '+' : rightAns = leftNum + rightNum;
                        break;
            case '-' : rightAns = leftNum - rightNum;
                        break;
            case '*' : rightAns = leftNum * rightNum;
                        break;
        }
        wrongAns = Random.Range(0,51);
    }
}
