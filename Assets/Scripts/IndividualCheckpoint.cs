using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCheckpoint : MonoBehaviour
{
    private TrackCheckpointSystem trackCheckpointSystem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Player"))
        {
            Debug.Log("Checkpoint Reached");
            trackCheckpointSystem.VehicleThroughCheckpoint(this);
        }
    }
    public void SetTrackCheckpoints(TrackCheckpointSystem tcs)
    {
        this.trackCheckpointSystem = tcs;
    }
}
