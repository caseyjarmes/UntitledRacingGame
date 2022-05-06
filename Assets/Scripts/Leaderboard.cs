using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public struct PlayerStats
{
    public string name;
    public int position;
    public float BestTime;
    //public float TotalTime;
    public float TimeEntered;
    public int Collected;
    public int CheckpointCleared; 
    public PlayerStats(string name,int pos,float time,int Collected,float besttime,int Checkpoints)
    {
        this.name = name;
        this.position = pos;
        TimeEntered = time;
        this.Collected = Collected;
        BestTime = besttime;
        CheckpointCleared = Checkpoints;
    }
}
public class Leaderboard
{
    public static Dictionary<int, PlayerStats> lb = new Dictionary<int, PlayerStats>();
    static int carsRegistered = -1;
    public static int RegisterCar(string name)
    {
        carsRegistered++;
        lb.Add(carsRegistered, new PlayerStats(name, 0,0,0,float.MaxValue,0));
        return carsRegistered;
    }

    public static void SetPosition(int rego,int lap, int checkpoint,float time,int coincount,float besttime)
    {
        //int position = lap * 1000;
        lb[rego] = new PlayerStats(lb[rego].name, GetPosition(rego),time,coincount,besttime,checkpoint);
    }
    public static int GetPosition(int rego)
    {
        int index = 0;
        foreach (KeyValuePair<int, PlayerStats> pos in lb.OrderByDescending(key => key.Value.CheckpointCleared)/*.ThenBy(key => key.Value.CheckpointCleared)*/)
        {
            index++;
            if(pos.Key == rego)
            {
                //Preparing for the future
                switch(index)
                {
                    case 1: return 1;
                    case 2: return 2;
                    case 3: return 3;
                    case 4: return 4;


                }
            }
        }
        return 99;
    }
    public static List<string> GetPlaces()
    {
        List<string> places = new List<string>();

        foreach (KeyValuePair<int, PlayerStats> pos in lb.OrderByDescending(key => key.Value.position).ThenBy(key => key.Value.TimeEntered))
        {
            places.Add(pos.Value.position.ToString());
        }
            return places;
    }
    public static List<string> GetNames()
    {
        List<string> places = new List<string>();

        foreach (KeyValuePair<int, PlayerStats> pos in lb.OrderByDescending(key => key.Value.position).ThenBy(key => key.Value.TimeEntered))
        {
            places.Add(pos.Value.name);
        }
        return places;
    }
    public static void ResetInfo()
    {
        lb.Clear();
        carsRegistered = -1;
    }
}
