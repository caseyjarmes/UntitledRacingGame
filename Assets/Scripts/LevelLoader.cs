using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class LevelLoader : MonoBehaviour
{
    private float progress;
    public Slider slider;
    public int value;
    public TMP_Dropdown track_dropdown;
    public TMP_Dropdown ship_dropdown;
    public TMP_Dropdown p1_ship_dropdown;
    public TMP_Dropdown p2_ship_dropdown;
    public TMP_Dropdown mode_dropdown;

    public void LoadLevel()
    {
        //set ship
        ShipChoice.ShipIndex = ship_dropdown.value;
        ShipChoice.P1ShipIndex = p1_ship_dropdown.value;
        ShipChoice.P2ShipIndex = p2_ship_dropdown.value;

        //set track
        value = track_dropdown.value + 1;
        StartCoroutine(LoadAsync(value));

        //set mode
        //This is now done in MainMenu.cs
        //GameManager.State = (GameState)mode_dropdown.value + 1; Dropdown version
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            progress = Mathf.Clamp01(operation.progress/.9f);
            slider.value = progress;
            Debug.Log(progress);

            yield return null;
        }
    }
}
