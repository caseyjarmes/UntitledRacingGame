using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoManager : MonoBehaviour
{
    public static VoManager voMan;
    private AudioSource voPickupLines;
    public AudioClip[] voPickup;
    private int randomPickupLine;

    void Start()
    {
        voMan = this;
        voPickupLines = GetComponent<AudioSource>();
    }

    public void PlayVoPickup()
    {
        randomPickupLine = UnityEngine.Random.Range(0, 4);
        voPickupLines.PlayOneShot(voPickup[randomPickupLine]);
    }
    
   
}
