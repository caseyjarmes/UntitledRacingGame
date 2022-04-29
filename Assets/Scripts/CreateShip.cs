using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//The playerIndex in the PlayerInput determines which player is on top/bottom.
//I have no idea how it is determined and its readonly so I can't change it manually

public class CreateShip : MonoBehaviour
{
    public List<GameObject> ships = new List<GameObject>();

    //takes in p1cam/p2cam for multiplayer
    public GameObject CameraHandler;

    //takes in a ShipStatsUI
    public GameObject UIHandler;

    //takes in a ___UIController
    public GameObject ShipUIController;

    //This is for setting the individual level for their specific lap count set in the unity editor freely
    public int TotalLapCount = 3;

    //mostly only used for hyperspeedway
    public float speed_mult = 1f;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.State == GameState.SinglePlayerTimeTrial)
        {
            InstantiateShip(ShipChoice.ShipIndex);
        }
        else if (GameManager.State == GameState.Multiplayer)
        {
            if (gameObject.tag == "Player2")
            {
                InstantiateShip(ShipChoice.P2ShipIndex);
            }
            else if (gameObject.tag == "Player1")
            {
                InstantiateShip(ShipChoice.P1ShipIndex);
            }
        }
    }

    public void InstantiateShip(int chosen_ship)
    {
        GameObject ship_reference;

        //Instantiates ship in place of the ShipSpawner object
        ship_reference = (GameObject)Instantiate(ships[chosen_ship], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(0, transform.eulerAngles.y, 0));

        ship_reference.GetComponent<CarControl>().speed *= speed_mult;
        ship_reference.GetComponent<LapTimeManager>().TotalLaps = TotalLapCount;

        SetUpCamera(ship_reference);
        SetUpUI(ship_reference);
    }

    public void SetUpCamera(GameObject ship_reference)
    {
        //for camera movement (during accel)
        CameraHandler.GetComponent<CinemachineManipulator>().CarControl = ship_reference.GetComponent<CarControl>();

        //camera follows ship
        CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().LookAt = ship_reference.transform.Find("followpoint");

        //for some reason this has to be different for the different modes
        if (GameManager.State == GameState.Multiplayer)
        {
            CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().Follow = ship_reference.transform.Find("followpoint");
        }
        else
        {
            CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().Follow = ship_reference.transform;
        }
    }

    public void SetUpUI(GameObject ship_reference)
    {
        //for speed and coins 
        UIHandler.GetComponent<ShipStatsUI>().CarControl = ship_reference.GetComponent<CarControl>();

        //for lap time/count
        ShipUIController.GetComponent<UiInGameTimeController>().LapTimeManager = ship_reference.GetComponent<LapTimeManager>();
    }

}
