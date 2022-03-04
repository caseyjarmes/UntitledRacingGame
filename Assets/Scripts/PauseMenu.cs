using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool game_paused = false;

    public GameObject pause_menu_ui;

    // Update is called once per frame
    void Update()
    {
        //refactor to be used with action map for controller support
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (game_paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        pause_menu_ui.SetActive(true);
        Time.timeScale = 0f;
        game_paused = true;
    }

    public void Resume()
    {
        pause_menu_ui.SetActive(false);
        Time.timeScale = 1f;
        game_paused = false;
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
