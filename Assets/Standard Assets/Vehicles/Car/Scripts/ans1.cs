using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car{
public class ans1 : MonoBehaviour
{
    // Start is called before the first frame update
    // CarController cars;
    public GameObject cars;
    void Start()
    {
        // cars = GameObject.FindGameObjectWithTag("Player").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        // mathQ.text = "";
        cars.GetComponent<CarController>().increaseSpeed();
    }
}
}