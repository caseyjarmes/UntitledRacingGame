using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiInGameTimeController : MonoBehaviour
{
    public GameObject UIRacePanel;
    public TextMeshProUGUI UIStartup,
        UITextCurrentLap,
        UITextCurrentLapTime,
        UITextPreviousLapTime,
        UITextBestLapTime,
        UITextTotalLapTime,
        UITextfinalLapTime,
        UITotalCoinsCollected,
        UITotalCoinsCollected2;
    
    public GameObject CompletedPanel;
    public LapTimeManager LapTimeManager;
    public ShipStatsUI shipStatsUI;
    public AudioSource start;

    private int CurrentLap = 0;
    private float CurrentLapTime;
    private float LastLapTime;
    private float BestLapTime;
    private float totalLapTime;
    private int count = 0;
    public static bool Started;
    void Start()
    {
        Started = false;
        StartCoroutine("StartupSequence");
        BestLapTime = LapTimeManager.BestLapTime;
    }

    IEnumerator StartupSequence()
    {
        //var inputhandler = GameObject.FindGameObjectsWithTag("");
        var players = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject player in players)
        {
            var input = player.GetComponent<CarControl>();
            input.enabled = false;
            start.Play();
        }
        var count = 4;
        while (count > 0)
        {
            players = GameObject.FindGameObjectsWithTag("Player");
            UIStartup.text = $"{count - 1}";
           // start.Play();
            if(count == 1)
            {
                UIStartup.text = "GO!";
                foreach (GameObject player in players)
                {
                    var input = player.GetComponent<CarControl>();
                    input.enabled = true;
                }
                Started = true;
            }
            yield return new WaitForSeconds(1f);
            --count;
        }

        yield return null;          
        if(UIStartup.IsActive())
        UIStartup.gameObject.SetActive(false);      
    }
    // Update is called once per frame
    void Update()
    {

        if (Started)
        {
            if (LapTimeManager == null)
                return;

            if (LapTimeManager.CurrentLap != CurrentLap)
            {
                CurrentLap = LapTimeManager.CurrentLap;
                UITextCurrentLap.text = $"LAP: {CurrentLap}/{LapTimeManager.TotalLaps}";
            }
            if (LapTimeManager.CurrentLapTime != CurrentLapTime)
            {
                CurrentLapTime = LapTimeManager.CurrentLapTime;
                UITextCurrentLapTime.text = $"Current Lap Time: {(int)CurrentLapTime / 60}:{(CurrentLapTime) % 60:00.000}";
            }
            if (LapTimeManager.LastLapTime != LastLapTime)
            {
                LastLapTime = LapTimeManager.LastLapTime;
                UITextPreviousLapTime.text = $"Previous Lap: {(int)LastLapTime / 60}:{(LastLapTime) % 60:00.000}";
            }
            if (LapTimeManager.BestLapTime != BestLapTime)
            {
                BestLapTime = LapTimeManager.BestLapTime;
                if (LapTimeManager.BestLapTime < Mathf.Infinity)
                    UITextBestLapTime.text = $"Best Lap: {(int)BestLapTime / 60}:{(BestLapTime) % 60:00.000}";
            }
            if (LapTimeManager.TotalLapTime != totalLapTime)
            {
                totalLapTime = LapTimeManager.TotalLapTime;
                UITextTotalLapTime.text = $"Total Time: {(int)totalLapTime / 60}:{(totalLapTime) % 60:00.000}";
                UITextfinalLapTime.text = $"Total Time: {(int)totalLapTime / 60}:{(totalLapTime) % 60:00.000}";
            }
            if (shipStatsUI.coins != count)
            {
                UITotalCoinsCollected2.text = $"Crystal Count: {shipStatsUI.coins}";
                UITotalCoinsCollected.text = $"Crystal Count: {shipStatsUI.coins}";
                count++;
            }
            if (LapTimeManager.completedgame)
            {
                UIRacePanel.SetActive(false);
                CompletedPanel.SetActive(true);
            }
        }
    }
}
