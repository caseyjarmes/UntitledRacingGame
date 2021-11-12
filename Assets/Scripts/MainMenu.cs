using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    // Update is called once per frame
    void Update()
    {
        
    }
}
