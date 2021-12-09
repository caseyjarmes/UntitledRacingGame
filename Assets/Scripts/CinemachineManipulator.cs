using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineManipulator : MonoBehaviour
{
    public CinemachineVirtualCamera ShipCam;
    float startingfov;
    // Start is called before the first frame update
    void Start()
    {
        ShipCam = GameObject.FindGameObjectWithTag("").GetComponent<CinemachineVirtualCamera>();
        startingfov = ShipCam.m_Lens.FieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
