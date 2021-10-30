using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    //public static ScoreManager instance;
    public int score;
    public int hightScore;

    /*
    private void Awake()
    {
        if (instance == null)
        { // ��������� ��������� ��� ������
            instance = this; // ������ ������ �� ��������� �������
        }
        else if (instance == this)
        { // ��������� ������� ��� ���������� �� �����
            Destroy(gameObject); // ������� ������
        }
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void incrementScore()
    {
        score += 1;
    }

    void startScore()
    {
        InvokeRepeating("incrementScore",0.1f,0.5f);
    }

    public void StopScore()
    {
        CancelInvoke("startScore");
        PlayerPrefs.SetInt("score", score);

        if (PlayerPrefs.HasKey("hightScore"))
        {
            if (score > PlayerPrefs.GetInt("hightScore"))
            {
                PlayerPrefs.SetInt("hightScore", score);
            }
        }
        else 
        {
            PlayerPrefs.SetInt("hightScore", score);
        }
    }
}
