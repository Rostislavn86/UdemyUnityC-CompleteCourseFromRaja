using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickTest : MonoBehaviour
{

    public GameObject cube;

    Button greenButton;

    // Start is called before the first frame update
    void Start()
    {
        greenButton = GameObject.Find("Green Button").GetComponent<Button>();

        greenButton.onClick.AddListener(() => ChangeToGreen() );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToRed()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    
    }

    public void ChangeToGreen()
    {
        cube.GetComponent<Renderer>().material.color = Color.green;

    }


}
