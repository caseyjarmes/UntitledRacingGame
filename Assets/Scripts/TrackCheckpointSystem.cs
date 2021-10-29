using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpointSystem : MonoBehaviour
{
    public List<IndividualCheckpoint> checkpointlist;
    public int NextCheckpointIndexvalue;
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
            //NextCheckpointIndexvalue=(NextCheckpointIndexvalue+1)%checkpointlist.Count;
            NextCheckpointIndexvalue++;
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }
        

    }
    public void ResetCheckpointIndex()
    {
        NextCheckpointIndexvalue = 0;
    }
}
