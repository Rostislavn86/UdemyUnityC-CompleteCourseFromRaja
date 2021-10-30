using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int point;
    private int lives;

    

    public int Point
    {
        get
        {
            return point;
        }

        set 
        {
            if (value > 5 && value < 10)
            {
                point = value;
            }
            PrintPoint();
            
        }
    }

    public int Lives { get; set; }
    //public int Lives { get;  }

    void PrintPoint()
    {
        Debug.Log(point);
    
    }



}
