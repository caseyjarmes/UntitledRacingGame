using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Button Selected;
    // Start is called before the first frame update
    void Start()
    {
        Selected.Select();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Speedway");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Survey()
    {
        Application.OpenURL("https://forms.gle/zqw7EjyC7Vi57zQ56");
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
