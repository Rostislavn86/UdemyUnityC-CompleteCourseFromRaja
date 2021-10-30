using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //Increment score

            GameMeneger.instance.IncrementScore();
            Destroy(gameObject);
        
        }

        if (collider.gameObject.tag == "Boundury")
        {
            //Decriment lives
            GameMeneger.instance.DecreaseLife();
            Destroy(gameObject);
        }
    }
}
