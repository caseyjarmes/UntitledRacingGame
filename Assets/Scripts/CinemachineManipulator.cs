using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineManipulator : MonoBehaviour
{
    public CinemachineVirtualCamera ShipCam;
    public CarControl CarControl;
    float startingfov;
    void Awake()
    {
        startingfov = ShipCam.m_Lens.FieldOfView;
    }
    // Start is called before the first frame update
    void Start()
    {
        //ShipCam = GameObject.FindGameObjectWithTag("Camera").GetComponent<CinemachineVirtualCamera>();
        //startingfov = ShipCam.m_Lens.FieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Car control: " + CarControl);

        //0.0166 70 for max speed 
        if(CarControl.SpeedInformation>40)
        ShipCam.m_Lens.FieldOfView = startingfov + (CarControl.SpeedInformation * 0.033f);
    }
}
