using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevitationSystem : MonoBehaviour
{
    Rigidbody rb;
    public float multiplier;
    public float DistanceofGround;
    public List<GameObject> LevPoints;
    //public List<RaycastHit> hits;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Start()
    {
                
        
    }
    private void FixedUpdate()
    { 
            HoverFunction();
    }
    void HoverFunction()
    {
        foreach(GameObject point in LevPoints)
        {
            RaycastHit hit;
            if(Physics.Raycast(point.transform.position, transform.TransformDirection(Vector3.down),out hit, DistanceofGround))
            {
                rb.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.up) * Mathf.Pow(DistanceofGround - hit.distance, 2) * DistanceofGround * multiplier, point.transform.position);
            }
        }

    }
}
