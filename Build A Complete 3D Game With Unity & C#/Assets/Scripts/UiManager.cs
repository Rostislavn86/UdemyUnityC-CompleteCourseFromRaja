using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

   

    public GameObject zigZagPanel;
    public GameObject gameOverPanal;
    public GameObject tapText;
    public Text score;
    public Text hiScore1;
    public Text hiScore2;

    private void Awake()
    {


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void GameStart()
    {
        tapText.SetActive(false);
        zigZagPanel.GetComponent<Animator>().Play("panelUp");
    }

    public void GameOver()
    {
        gameOverPanal.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene("level1");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
