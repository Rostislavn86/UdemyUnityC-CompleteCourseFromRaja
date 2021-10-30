using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    public enum GameState {Ready, Play, Pause, GameOver };

    public GameState state;

    private void Start()
    {
        state = GameState.Ready;
    }

    private void Update()
    {
        switch (state)
        {
            case GameState.Ready:
                print("You Are Ready");
                break;
            case GameState.Play:
                print("You Are Play");
                break;
            case GameState.Pause:
                print("You Are Pause");
                break;
            case GameState.GameOver:
                print("You Are GameOver");
                break;

        }
    }

}
