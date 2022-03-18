using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public int lap = 0;
    public int checkPoint = -1;
    public int checkPointCount = 0;
    int nextCheckPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        checkPointCount = GameObject.FindGameObjectsWithTag("Checkpoint").Length - 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            int thisCheckpointNumber = int.Parse(other.gameObject.name);
            if (thisCheckpointNumber == nextCheckPoint)
            {
                checkPoint = thisCheckpointNumber;
                if (checkPoint == checkPointCount)
                {
                    //lap++;
                    nextCheckPoint = 0;
                }
                    nextCheckPoint++;                
            }
        }
    }
}
