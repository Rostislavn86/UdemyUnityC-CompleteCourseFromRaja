using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLoadingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fun fun = new Fun();

        //fun.printFloat(2.5f);

        //fun.printInt(1);

        //fun.printString("asdasd");

        fun.Print(2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



}


public class Fun
{
    public void printInt(int i)
    {
        Debug.Log(i);
    }

    public void printFloat(float i)
    {
        Debug.Log(i);
    }

    public void printString(string i)
    {
        Debug.Log(i);
    }

    public void Print(int i)
    {
        Debug.Log("Print(int i) Getthering Colled");

    }

    public void Print(float i)
    {
        Debug.Log("Print(float i) Getthering Colled");

    }

    public void Print(string i)
    {
        Debug.Log("Print(string i) Getthering Colled");

    }




}





