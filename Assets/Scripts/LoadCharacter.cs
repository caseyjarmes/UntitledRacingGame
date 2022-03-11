using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public CharacterSelecter CharacterSelecter;
    public List<GameObject> ShipList;

    public Transform Player1SpawnLocation;
    public Transform Player2SpawnLocation;
    public int Player1SelectedShipNumber;
    public int Player2SelectedShipNumber;
    private void Start()
    {
        CharacterSelecter = GetComponent<CharacterSelecter>();
        //Player1SelectedShipNumber = CharacterSelecter.Player1.value;
        //Player2SelectedShipNumber = SelectedCharacter2;
        GameObject spawningShip = ShipList[Player1SelectedShipNumber];
        Instantiate(spawningShip, Player1SpawnLocation.position, Player2SpawnLocation.rotation);
}
    void Update()
    {
        
    }
}
