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
        switch (trackSelect.value)
        {
            case 0:
                SceneManager.LoadScene(1);
                break;
            case 1:
                SceneManager.LoadScene(2);
                break;
            case 2:
                SceneManager.LoadScene(3);
                break;
            default:
                break;
        }




        //if (trackSelect.value == 0)
        //{
        //    SceneManager.LoadScene(1);
        //}
        //else if (trackSelect.value == 1)
        //{
        //    SceneManager.LoadScene(2);
        //}
        //else if (trackSelect.value == 2)
        //{
        //    SceneManager.LoadScene(3);
        //}
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
