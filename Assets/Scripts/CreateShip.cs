using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShip : MonoBehaviour
{
    public List<GameObject> ships = new List<GameObject>();
    public GameObject CameraHandler;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateShip(ShipChoice.ShipIndex);
    }

    public void InstantiateShip(int chosen_ship)
    {
        GameObject ship_reference;

        ship_reference = (GameObject)Instantiate(ships[chosen_ship], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(0, transform.eulerAngles.y, 0));

        SetUpCamera(ship_reference);
    }

    public void SetUpCamera(GameObject ship_reference)
    {
        //for camera movement (during accel)
        CameraHandler.GetComponent<CinemachineManipulator>().CarControl = ship_reference.GetComponent<CarControl>();

        //camera follows ship
        CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().Follow = ship_reference.transform;
        CameraHandler.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().LookAt = ship_reference.transform.GetChild(1);
    }
}
