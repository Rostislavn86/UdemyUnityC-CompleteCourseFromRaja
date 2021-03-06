using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameMeneger : MonoBehaviour
{
    public static GameMeneger instance;

    public GameObject livesHolder;
    public GameObject gameOverPanel;

    int score = 0;
    int lives = 3;
    bool gameOver = false;

    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }

        score++;

        scoreText.text = score.ToString();

       // print(score);    
    }

    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            print(lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if (lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    public void GameOver()
    {
        //????????????? ???????? ??????
        CandySpowner.instance.StopSpowingCandies();

        //????????????? ?????? 
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;

        gameOverPanel.SetActive(true);
        print("Game Over");
    
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
