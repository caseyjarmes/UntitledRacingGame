using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class LevelLoader : MonoBehaviour
{
    private float progress;
    //public GameObject LoadingScreen;
    public Slider slider;
    public int value;
    public TMP_Dropdown dropdown;
    public void LoadLevel()
    {
        value = dropdown.value+1;
        StartCoroutine(LoadAsync(value));
    }
    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        //LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            progress = Mathf.Clamp01(operation.progress/.9f);
            slider.value = progress;
            Debug.Log(progress);

            yield return null;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
