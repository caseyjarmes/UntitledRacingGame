using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script assumes that all checkpoints in the game have the tag "Checkpoint" 
///on them as well as numbers for each checkpoint starting with 0 and ending it 
///on the finish line with the biggest value in the gameobject name in the inspector
/// </summary>
public class CheckpointManager : MonoBehaviour
{
    //Lap count to be seen in the inspector
    public int lap = 0;
    //checkpoint value to show its position in the environment
    public int checkPoint = -1;
    //base value of the amount of checkpoints in the game scene to be used to verify when a ship goes across the whole level
    public int checkPointCount = 0;
    //The next checkpoint that the ship has to contact with in order to progress in the level
    int nextCheckPoint = 0;
    public float TimeEntered = 0;
    void Start()
    {
        //Each level would have a special count of checkpoints and this will cover all of them
        checkPointCount = GameObject.FindGameObjectsWithTag("Checkpoint").Length - 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        //The only thing that this script will handle will be for checkpoints only
        if (other.gameObject.tag == "Checkpoint")
        {
            //The collider will touch a gameobject whose name will only be a number value
            int thisCheckpointNumber = int.Parse(other.gameObject.name);
            if (thisCheckpointNumber == nextCheckPoint)
            {           
                //a variable used for the sorting in the dictonary
                TimeEntered = Time.time;
                checkPoint = thisCheckpointNumber;
                if (checkPoint == checkPointCount)
                {
                    //makes it become a new lap
                    nextCheckPoint = 0;
                }
                    nextCheckPoint++;                
            }
        }
    }

}
