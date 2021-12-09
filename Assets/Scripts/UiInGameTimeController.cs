using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiInGameTimeController : MonoBehaviour
{
    public GameObject UIRacePanel;
    public TextMeshProUGUI UITextCurrentLap;
    public TextMeshProUGUI UITextCurrentLapTime;
    public TextMeshProUGUI UITextPreviousLapTime;
    public TextMeshProUGUI UITextBestLapTime;
    public TextMeshProUGUI UITextTotalLapTime;
    public TextMeshProUGUI UITextfinalLapTime;
    public TextMeshProUGUI UITotalCoinsCollected;

    public GameObject CompletedPanel;
    public LapTimeManager LapTimeManager;
    public ShipStatsUI shipStatsUI;


    private int CurrentLap =0;
    private float CurrentLapTime;
    private float LastLapTime;
    private float BestLapTime;
    private float totalLapTime;
    private int count = 0;
    // Update is called once per frame
    void Update()
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
            //if(LapTimeManager.BestLapTime!=Mathf.Infinity)
            UITextCurrentLapTime.text = $"Current Lap Time: {(int)CurrentLapTime/60}:{(CurrentLapTime)%60:00.000}";
        }
        if (LapTimeManager.LastLapTime != LastLapTime)
        {
            LastLapTime = LapTimeManager.LastLapTime;
            UITextPreviousLapTime.text = $"Previous Lap: {(int)LastLapTime / 60}:{(LastLapTime) % 60:00.000}";
        }
        if (LapTimeManager.BestLapTime != BestLapTime)
        {
            BestLapTime = LapTimeManager.BestLapTime;
            if (LapTimeManager.BestLapTime != Mathf.Infinity)
                UITextBestLapTime.text = $"Best Lap: {(int)BestLapTime / 60}:{(BestLapTime) % 60:00.000}";
        }
        if(LapTimeManager.TotalLapTime!=totalLapTime)
        {
            totalLapTime = LapTimeManager.TotalLapTime;
            UITextTotalLapTime.text = $"Total Time: {(int)totalLapTime/60}:{(totalLapTime)%60:00.000}";
            UITextfinalLapTime.text = $"Total Time: {(int)totalLapTime / 60}:{(totalLapTime) % 60:00.000}";
        }
        if (shipStatsUI.coins != count)
        {
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
