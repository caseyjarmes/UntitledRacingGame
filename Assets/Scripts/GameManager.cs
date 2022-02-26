using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum GameState { Menu, SinglePlayerTimeTrial,Multiplayer}
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameState State = GameState.SinglePlayerTimeTrial;

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
    // Start is called before the first frame update
    void Start()
    {

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
