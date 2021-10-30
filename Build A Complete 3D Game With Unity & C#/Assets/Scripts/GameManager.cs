using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  
    public bool gameOver;
    public GameObject ball;
    
    


    // Start is called before the first frame update
    void Start()
    {
        gameOver = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y != 0.94f)
        {
            SceneManager.LoadScene("level1");
        }
    }

    public void StartGame()
    {
       // UiManager.instance.GameStart();

    }

    public void GameOver()
    {
    //    UiManager.instance.GameOver();
     //   ScoreManager.instance.StopScore();
    }
}
