using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Button Selected;
    public TMP_Dropdown trackSelect;

    // Start is called before the first frame update
    void Start()
    {
        Selected.Select();

    }
    public void PlayGame()
    {
        if (trackSelect.value == 0)
        {
            SceneManager.LoadScene("Speedway");
        }
        else if (trackSelect.value == 1)
        {
            SceneManager.LoadScene("Crashsite");
        }
        else if (trackSelect.value == 2)
        {
            SceneManager.LoadScene("Downtown");
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {

    }
    public void Return()
    {
        SceneManager.LoadScene("Main Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
