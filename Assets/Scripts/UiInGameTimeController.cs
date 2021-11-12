using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiInGameTimeController : MonoBehaviour
{
    public GameObject UIRacePanel;
    public Text UITextCurrentLap;
    public Text UITextCurrentLapTime;
    public Text UITextPreviousLapTime;
    public Text UITextBestLapTime;
    

    public LapTimeManager LapTimeManager;

    private int CurrentLap =0;
    private float CurrentLapTime;
    private float LastLapTime;
    private float BestLapTime;
    // Update is called once per frame
    void Update()
    {
        if (LapTimeManager == null)
            return;

        if (LapTimeManager.CurrentLap != CurrentLap)
        {
            CurrentLap = LapTimeManager.CurrentLap;
            UITextCurrentLap.text = $"LAP: {CurrentLap}";
        }
        if (LapTimeManager.CurrentLapTime != CurrentLapTime)
        {
            CurrentLapTime = LapTimeManager.CurrentLapTime;
            UITextCurrentLapTime.text = $"Current Lap: {(int)CurrentLapTime/60}:{(CurrentLapTime)%60:00.000}";
        }
        if (LapTimeManager.LastLapTime != LastLapTime)
        {
            LastLapTime = LapTimeManager.LastLapTime;
            UITextPreviousLapTime.text = $"Previous Lap: {(int)LastLapTime / 60}:{(LastLapTime) % 60:00.000}";
        }
        if (LapTimeManager.BestLapTime != BestLapTime)
        {
            BestLapTime = LapTimeManager.BestLapTime;
            UITextBestLapTime.text = $"Best Lap: {(int)BestLapTime / 60}:{(BestLapTime) % 60:00.000}";
        }
        
    }
}
