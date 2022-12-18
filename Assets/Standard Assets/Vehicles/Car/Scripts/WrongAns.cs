using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace UnityStandardAssets.Vehicles.Car{
    public class WrongAns : MonoBehaviour
    {
        // Start is called before the first frame update
        // CarController cars;
        public GameObject cars;
        public Text mathq;
        public TMP_Text ans;
        public GameObject box;
        void Start()
        {
            // cars = GameObject.FindGameObjectWithTag("Player").GetComponent<CarController>();
        }

        // Update is called once per frame
        void Update()
        {
            ans.text = MathCollider.wrongAns.ToString();
        }

        void OnTriggerEnter(){
            mathq.text = "Wrong Answer! Your max speed has decreased by 5 mph";
            cars.GetComponent<CarController>().decreaseSpeed();
            box.SetActive(false);
        }
    }
}