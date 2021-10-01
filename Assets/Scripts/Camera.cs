using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform vehicle;
    public float toSmooth;
    public float rotationSmooth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,vehicle.position,toSmooth);
        transform.rotation = Quaternion.Slerp(transform.rotation, vehicle.rotation, rotationSmooth);
    }
}
