using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Pickup { Coins, Weapons }
public class PickupSystem : MonoBehaviour
{
    public Pickup Pickup;
    private AudioClip Audio;
    private AudioSource AudioPlayer;
    private GameObject ParticleEffect;
    // Start is called before the first frame update
    void Start()
    {
        AudioPlayer = GetComponent<AudioSource>();
        switch (Pickup)
        {
            case Pickup.Coins:
                //Audio = Resources.Load<AudioClip>("Pickups/Insertnamehere");

                ParticleEffect = Resources.Load<GameObject>("Pickups/CoinPickupParticle");
                break;
            case Pickup.Weapons:
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(Instantiate(ParticleEffect,transform.position,Quaternion.identity) as GameObject,2.6f);
        //AudioPlayer.PlayOneShot(Audio);
    }
    
        
   
}
