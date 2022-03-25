using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public struct PlayerStats
{
    public string name;
    public int position;
    //public float BestTime;
    //public float TotalTime;
    public float TimeEntered;
    public PlayerStats(string name,int pos,float time)
    {
        this.name = name;
        this.position = pos;
        TimeEntered = time;
    }
}
public class Leaderboard
{
    public static Dictionary<int, PlayerStats> lb = new Dictionary<int, PlayerStats>();
    static int carsRegistered = -1;
    public static int RegisterCar(string name)
    {
        carsRegistered++;
        lb.Add(carsRegistered, new PlayerStats(name, 0,0));
        return carsRegistered;
    }

    public static void SetPosition(int rego,int lap, int checkpoint,float time)
    {
        int position = lap * 1000;
        lb[rego] = new PlayerStats(lb[rego].name, position,time);
    }
    public static string GetPosition(int rego)
    {
        int index = 0;
        foreach (KeyValuePair<int, PlayerStats> pos in lb.OrderByDescending(key => key.Value.position).ThenBy(key => key.Value.TimeEntered))
        {
            index++;
            if(pos.Key == rego)
            {
                //Preparing for the future
                switch(index)
                {
                    case 1: return "1st";
                    case 2: return "2nd";
                    case 3: return "3rd";
                    case 4: return "4th";


                }
            }
        }
        return "Unknown Position";
    }
    public static List<string> GetPlaces()
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
