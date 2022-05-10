using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//The main handler of the lap timer procedure
public class LapTimeManager : MonoBehaviour
{
    //audio shit
    public float volume;
    public AudioClip lapA;
    public AudioClip lapB;
    public AudioClip Win;
    AudioSource audioSource;
    int r;

    public float BestLapTime { get; private set; } = Mathf.Infinity;
    public float LastLapTime { get; private set; }
    public float CurrentLapTime { get; private set; }
    public float TotalLapTime { get; private set; }

    public AudioSource lap;
    public AudioSource voFinish;
    private float lapTimerTimeStamp;
    //public TrackCheckpointSystem trackCheckpointSystem;
    public CheckpointManager CPManager;
    public int CurrentLap { get; private set; }
    public int TotalLaps;
    private int interncounter;
    public bool completedgame;
    public static bool Completedgame;
    public int carRego;
    // this will be the string that will be shown up to the ui about their relative
    // position in regards to their competitors 
    public string PositionInfo;
    public CarControl Car;
    void Awake()
    {
        //trackCheckpointSystem = GameObject.Find("Track").GetComponent<TrackCheckpointSystem>();
        CPManager = GetComponent<CheckpointManager>();
        
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Car = GetComponent<CarControl>();
        StartLap();
        carRego = Leaderboard.RegisterCar(Car.ShipName);
    }
    void EndLap()
    {
        LastLapTime = CurrentLapTime;
        BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
        TotalLapTime += LastLapTime;
        CurrentLapTime = 0;
        //END LAP SOUND TRIGGER
        if(CurrentLap != TotalLaps)
        {
            r = UnityEngine.Random.Range(0, 2);
            if (r == 0)
            {
                audioSource.PlayOneShot(lapA, volume);
            }
            else
            {
                audioSource.PlayOneShot(lapB, volume);
            }
            
        }
        //VoManager.voMan.PlayVoLap();
        //lap.Play();
        //FINISH GAME SOUND
        if (CurrentLap == TotalLaps)
        {
            audioSource.PlayOneShot(Win, volume);
            //play finish vo 
            //voFinish.Play();
        }
    }
    void StartLap()
    {

        CurrentLap++;
        CPManager.lap = CurrentLap;
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

        if (UiInGameTimeController.StartedData)
        {
            if (CurrentLap == 1)
            {
                CurrentLapTime += Time.deltaTime;
            }
            else
            {
                CurrentLapTime += lapTimerTimeStamp > 0 ? Time.deltaTime : 0;
            }
            if (CPManager.checkPoint == CPManager.checkPointCount)
            {
                EndLap();
                CPManager.checkPoint = -1;
                //trackCheckpointSystem.ResetCheckpointIndex();
                if (CurrentLap != TotalLaps)
                {
                    StartLap();
                }
                else
                {
                    completedgame = true;
                    //Completedgame = true;
                    //transform.gameObject.SetActive(false);
                    //SceneManager.LoadScene("Main Menu");
                    //End the race here
                }
            }
        }
    }
    void LateUpdate()
    {
        Leaderboard.SetPosition(carRego, CPManager.TotalCheckpointsPassed, CPManager.TimeEntered, Car.CoinsCollected, BestLapTime);
    }
}
