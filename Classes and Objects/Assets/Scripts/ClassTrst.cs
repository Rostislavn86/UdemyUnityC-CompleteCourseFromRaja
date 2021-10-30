using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class ClassTrst : MonoBehaviour
{
    // public int speed; 

    public Car myCar;


    // Start is called before the first frame update
    void Start()
    {
        /*
        Car myCar = new Car();

        myCar.speed = 10.5f;
        myCar.color = "Red";
        myCar.highestSpeed = 20;

        Car suzuki = new Car();

        suzuki.speed = 15f;
        suzuki.color = "Green";
        suzuki.highestSpeed = 25;

        myCar.CarSpeed();

        suzuki.CarSpeed();

        Car myCar2 = new Car(2.5f,"Red");
       */

        myCar.PrintCarDetails();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
