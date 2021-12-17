using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoManager : MonoBehaviour
{
    public static VoManager voMan;
    private AudioSource voPickupLines;
    private AudioSource voLapLines;
    public AudioClip[] voPickup;
    public AudioClip[] voLap;
    private int randomPickupLine;
    private int randomLapLine;

    void Start()
    {
        voMan = this;
        voPickupLines = GetComponent<AudioSource>();
        voLapLines = GetComponent<AudioSource>();
    }

    public void PlayVoPickup()
    {
        randomPickupLine = UnityEngine.Random.Range(0, 4);
        voPickupLines.PlayOneShot(voPickup[randomPickupLine]);
    }

    public void PlayVoLap()
    {
        randomLapLine = UnityEngine.Random.Range(0, 3);
        voPickupLines.PlayOneShot(voLap[randomLapLine]);
    }
    
   
}
