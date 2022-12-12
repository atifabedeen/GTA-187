using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class MathAns : MonoBehaviour
{
    // Start is called before the first frame update
    public Text mathQ;
    // CarController cars;

    void Start()
    {
        // cars = GameObject.FindGameObjectWithTag("Player").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        mathQ.text = "";
        // car.increaseSpeed();
        // cars.increaseSpeed();
    }
}
