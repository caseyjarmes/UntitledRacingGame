using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public float BestLapTime { get; private set; } = Mathf.Infinity;
    public float LastLapTime { get; private set; }
    public float CurrentLapTime { get; private set; }
    
    private float lapTimerTimeStamp;
    public TrackCheckpointSystem trackCheckpointSystem;
    public int CurrentLap { get; private set; }
    public int TotalLaps;
    
    void Awake()
    {
        trackCheckpointSystem = GameObject.Find("Track").GetComponent<TrackCheckpointSystem>();
        
    }
    void Start()
    {
        StartLap();
    }
    void EndLap()
    {
        LastLapTime = Time.time - lapTimerTimeStamp;
        BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
        
    }
    void StartLap()
    {
        CurrentLap++;
        lapTimerTimeStamp = Time.time;
        Debug.Log("New Lap");
    }
    void Update()
    {
        if (CurrentLap == 1)
        {
            CurrentLapTime = Time.time;
        }
        else 
        {        
            CurrentLapTime = lapTimerTimeStamp > 0 ? Time.time - lapTimerTimeStamp : 0;
        }
        if (trackCheckpointSystem.NextCheckpointIndexvalue==trackCheckpointSystem.checkpointlist.Count)
        {
            EndLap();
            trackCheckpointSystem.ResetCheckpointIndex();
            if (CurrentLap != TotalLaps)
            {
                StartLap();
            }
            else
            {
                //End the race here
            }
        }
    }
}
