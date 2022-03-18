using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShip : MonoBehaviour
{
    public List<GameObject> ships = new List<GameObject>();
    public GameObject CameraHandler;
    public GameObject UIHandler;
    //This is for setting the individual level for their specific lap count set in the unity editor freely
    public int TotalLapCount = 3;

    //mostly only used for hyperspeedway
    public float speed_mult = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateShip(ShipChoice.ShipIndex);
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
        CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().Follow = ship_reference.transform;
        CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().LookAt = ship_reference.transform.GetChild(1);
    }

    public void SetUpUI(GameObject ship_reference)
    {
        UIHandler.GetComponent<ShipStatsUI>().CarControl = ship_reference.GetComponent<CarControl>();
    }

}
