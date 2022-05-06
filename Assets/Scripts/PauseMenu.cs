using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public static bool game_paused = false;

    public GameObject pause_menu_ui;
    public Button resume_button;

    // Update is called once per frame
    void Update()
    {
        //refactor to be used with action map for cleaner controller support
        if (Input.GetKeyDown(KeyCode.Escape) || (Gamepad.current != null && Gamepad.current.startButton.wasPressedThisFrame))
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
        resume_button.Select();
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
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
