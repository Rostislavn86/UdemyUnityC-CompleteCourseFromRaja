using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRutineTest : MonoBehaviour
{

    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("Test");

       // Test2();

        StartCoroutine("Test3", 4);

        for (int i = 0; i < 6; i++)
        {
            print("Start()");
        }

        //StopCoroutine("Test3");

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Test()
    {
        print(" Co Rutine Startss");


        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2f);

        GetComponent<Renderer>().material.color = Color.green;

        yield return null;

        print(" Courotine Ends");

    }

    void Test2()
    {
        for (int i = 0; i <6; i++)
        {
            print("Test2()");  
        }
    
    }

    IEnumerator Test3(int times)
    {
        for (int i = 0; i < times; i++)
        {
            print("Test3()");
        }

        yield return null;

    }

}
