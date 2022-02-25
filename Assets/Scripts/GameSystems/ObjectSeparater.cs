using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSeparater : MonoBehaviour
{
    public GameObject ShipSinglePlayer;
    public GameObject Multiplayer;
    // Start is called before the first frame update
    void Awake()
    {
        GameManager.State = GameState.Multiplayer;
        switch (GameManager.State)
        {
            case GameState.Menu:
                break;
            case GameState.SinglePlayerTimeTrial:
                var objs = GameObject.FindGameObjectsWithTag("Multiplayer");
                foreach(GameObject o in objs)
                {
                    Destroy(o);
                }
                ShipSinglePlayer.transform.DetachChildren();
                Destroy(ShipSinglePlayer);
                break;
            case GameState.Multiplayer:
                var Multiobjs = GameObject.FindGameObjectsWithTag("SinglePlayer");
                foreach (GameObject o in Multiobjs)
                {
                    Destroy(o);
                }
                Multiplayer.transform.GetChild(0).gameObject.SetActive(true);
                Multiplayer.transform.GetChild(1).gameObject.SetActive(true);
                Multiplayer.transform.GetChild(2).gameObject.SetActive(true);
                Multiplayer.transform.GetChild(3).gameObject.SetActive(true);
                Multiplayer.transform.DetachChildren();
                Destroy(Multiplayer);
                break;
            default:
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
