using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpointSystem : MonoBehaviour
{
    List<IndividualCheckpoint> checkpointlist;
    private int NextCheckpointIndexvalue;
    private void Awake()
    {
        Transform CheckpointsTransform = transform.Find("CheckpointSystem");

        checkpointlist = new List<IndividualCheckpoint>();
        foreach(Transform chectpointSingleTransform in CheckpointsTransform)
        {
            IndividualCheckpoint ic = chectpointSingleTransform.GetComponent<IndividualCheckpoint>();
            ic.SetTrackCheckpoints(this);
            checkpointlist.Add(ic);
            Debug.Log(chectpointSingleTransform);
        }
        NextCheckpointIndexvalue = 0;
    }
    public void VehicleThroughCheckpoint(IndividualCheckpoint cs)
    {        
        Debug.Log($"Checkpoint Reached: {checkpointlist.IndexOf(cs)}");
        if (checkpointlist.IndexOf(cs) == NextCheckpointIndexvalue)
        {
            NextCheckpointIndexvalue+=1%checkpointlist.Count;
            
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }
        

    }
}
