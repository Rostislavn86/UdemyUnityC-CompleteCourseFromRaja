using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Car 
{
    public float speed;
    public string color;
    public int highestSpeed;

    public Car()
    {
        Debug.Log("Car() Called");


    }

    public Car(float speed)
    {

        this.speed = speed;
        Debug.Log("load constructor with speed ");
    
    }

    public Car(float speed, string color)
    {
        this.speed = speed;
        this.color = color;
        Debug.Log("load constructor with speed and Color ");
    }


    void Move()
    {
        Debug.Log("Moving");

    }

    void ApllyBrake()
    {
        Debug.Log("Appling Brake");

    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    
    }

    public void PrintCarDetails()
    {
        Debug.Log("Speed = " + speed);
        Debug.Log("Color = " + color);
        Debug.Log("Higher Speed = " + highestSpeed);
    }

}
