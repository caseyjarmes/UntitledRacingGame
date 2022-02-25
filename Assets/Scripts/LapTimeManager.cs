using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapTimeManager : MonoBehaviour
{
    public float BestLapTime { get; private set; } = Mathf.Infinity;
    public float LastLapTime { get; private set; }
    public float CurrentLapTime { get; private set; }
    public float TotalLapTime { get; private set; }

    public AudioSource lap;
    public AudioSource voFinish;
    private float lapTimerTimeStamp;
    public TrackCheckpointSystem trackCheckpointSystem;
    public int CurrentLap { get; private set; }
    public int TotalLaps;
    private int interncounter;
    public bool completedgame;
    
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
        LastLapTime = CurrentLapTime;
        BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
        TotalLapTime += LastLapTime;
        CurrentLapTime = 0;
        //END LAP SOUND TRIGGER
        if(CurrentLap != TotalLaps)
        VoManager.voMan.PlayVoLap();
        lap.Play();
        //FINISH GAME SOUND
        if (CurrentLap == TotalLaps)
        {
            //play finish vo 
            voFinish.Play();
        }
    }
    void StartLap()
    {

            CurrentLap++;
            if (LastLapTime == 0)
            {
            lapTimerTimeStamp = 0;

            }
            else
            {
            lapTimerTimeStamp = LastLapTime;
            }
            Debug.Log("New Lap");
        
    }
    void Update()
    {
        if (UiInGameTimeController.Started)
        {
            if (CurrentLap == 1)
            {
                CurrentLapTime += Time.deltaTime;
            }
            else
            {
                CurrentLapTime += lapTimerTimeStamp > 0 ? Time.deltaTime : 0;
            }
            if (trackCheckpointSystem.NextCheckpointIndexvalue == trackCheckpointSystem.checkpointlist.Count)
            {
                EndLap();
                trackCheckpointSystem.ResetCheckpointIndex();
                if (CurrentLap != TotalLaps)
                {
                    StartLap();
                }
                else
                {
                    completedgame = true;
                    //transform.gameObject.SetActive(false);
                    //SceneManager.LoadScene("Main Menu");
                    //End the race here
                }
            }
        }
    }
}
