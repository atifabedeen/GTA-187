using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car{
public class ans1 : MonoBehaviour
{
    // Start is called before the first frame update
    // CarController cars;
    public GameObject cars;
    public Text mathq;
    public GameObject box;
    void Start()
    {
        // cars = GameObject.FindGameObjectWithTag("Player").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        mathq.text = "Correct Answer! Your max speed has increased by 20 mph";
        cars.GetComponent<CarController>().increaseSpeed();
        box.SetActive(false);
    }
}
}