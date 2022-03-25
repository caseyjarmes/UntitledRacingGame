using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum GameState { Menu = 0, SinglePlayerTimeTrial,Multiplayer}
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameState State;// = GameState.SinglePlayerTimeTrial;

    public PlayerInputHandler[] players;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
                instance = this;
                DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (LapTimeManager.Completedgame)
        //{
        //    State = GameState.SinglePlayerTimeTrial;
        //    SceneManager.LoadScene(0);

        //}

    }
}
