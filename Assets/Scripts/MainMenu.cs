using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Button Selected;
    
    public GameObject StartButton;

    public GameObject ModePanel;
    public GameObject ShipPanel;
    public GameObject MPShipPanel;
    public GameObject TrackPanel;

    // Start is called before the first frame update
    void Start()
    {
        Selected.Select();
    }

    //Unused, this functionality is now in LevelLoader.cs
    public void PlayGame()
    {
        /*
        switch (trackSelect.value)
        {
            case 0:
                //GameManager.State = 
                SceneManager.LoadScene(1);
                break;
            case 1:
                SceneManager.LoadScene(2);
                break;
            case 2:
                SceneManager.LoadScene(3);
                break;
            case 3:
                SceneManager.LoadScene(4);
                break;
            default:
                break;
        }
        */
    }

    public void OnTimeTrialsClicked()
    {
        GameManager.State = GameState.SinglePlayerTimeTrial;

        NavigateToShip();
    }

    public void OnMultiplayerClicked()
    {
        GameManager.State = GameState.Multiplayer;

        NavigateToMPShip();
    }

    public void NavigateToMode()
    {
        ModePanel.SetActive(true);
        ShipPanel.SetActive(false);
        TrackPanel.SetActive(false);

        StartButton.SetActive(false);
        MPShipPanel.SetActive(false);
    }

    public void NavigateToShip()
    {
        ModePanel.SetActive(false);
        ShipPanel.SetActive(true);
        TrackPanel.SetActive(false);

        StartButton.SetActive(false);
    }

    public void NavigateToMPShip()
    {
        ModePanel.SetActive(false);
        MPShipPanel.SetActive(true);
        TrackPanel.SetActive(false);

        StartButton.SetActive(false);
    }

    public void NavigateToTrack()
    {
        ModePanel.SetActive(false);
        ShipPanel.SetActive(false);
        TrackPanel.SetActive(true);

        StartButton.SetActive(true);
        MPShipPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        Application.OpenURL("https://github.com/caseyjarmes/UntitledRacingGame");
    }
    public void Return()
    {
        Leaderboard.ResetInfo();
        SceneManager.LoadScene("Main Menu");
    }
}
