using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarControl : MonoBehaviour
{
    private MainControl inputs;
    public Rigidbody rb;
    public float speed;
    public float TorqueSpeed;
    private Vector3 localvelocity;
    private float xClampAxisAngle;
    private float zClampAxisAngle;
    private Vector3 groundNormal;

    public GameObject ship;

    private bool isOnGround;
    public LayerMask ground;

    public static int CoinsCollected { get; private set; }

    Transform checkpointRotation;
    
    private void Awake()
    {
        inputs = new MainControl();
        rb = GetComponent<Rigidbody>();
        
    }
    private void OnEnable()
    {
        inputs.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        xClampAxisAngle = rb.transform.rotation.x;
        zClampAxisAngle = rb.transform.rotation.z;
        //ClampVehicleRotation();

        float valueSpeed = inputs.VehicleControl.TrottleControl.ReadValue<float>();
        rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed);

        //This system is intended to keep the velocity of the
        //object only foward facing of the vehicle
        //If you turn it on drastically increase the speed to normalize it

        //transform.InverseTransformDirection(localvelocity*.5f);
        //localvelocity.x = 0;
        //rb.velocity = transform.TransformDirection(localvelocity);
        Ray ray = new Ray(rb.position, Vector3.down);
        RaycastHit hitinfo;
        isOnGround = Physics.Raycast(ray, out hitinfo,2f, ground);
        //Keep adjustable torque value Very small hundredths or thousands
        float valueturn = inputs.VehicleControl.Movement.ReadValue<float>();
        rb.AddRelativeTorque(new Vector3(0, valueturn)*TorqueSpeed);
        if (isOnGround) 
        {
            groundNormal = hitinfo.normal.normalized;
        }
        else
        {        
            LimitRotations();
            groundNormal = Vector3.up;
            rb.AddForce(-groundNormal * 4, ForceMode.Acceleration);
        }        
    }

    private void LimitRotations()
    {
        Vector3 projection = Vector3.ProjectOnPlane(transform.forward, groundNormal);
        Quaternion rotations = Quaternion.LookRotation(projection, groundNormal);
        rb.MoveRotation(Quaternion.Lerp(rb.rotation, rotations, Time.deltaTime * 1f));
    }

    private void ClampVehicleRotation()
    {
        xClampAxisAngle = Mathf.Clamp(xClampAxisAngle, -45, 45);
        zClampAxisAngle = Mathf.Clamp(zClampAxisAngle, -30, 30);
        rb.transform.rotation = Quaternion.Euler(xClampAxisAngle, 0, 0);
        rb.transform.rotation = Quaternion.Euler(0, 0, zClampAxisAngle);
        
        //rb.transform.rotation = Quaternion.Lerp(rb.transform.rotation, toclamp, Time.deltaTime,.75);

    }
    private void FixRotation()
    {
        rb.transform.rotation = Quaternion.Lerp(rb.rotation, checkpointRotation.rotation, .5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Checkpoint"))
        {
            checkpointRotation.rotation = other.transform.rotation;
        }
        if(other.gameObject.layer == LayerMask.NameToLayer("respawner"))
        {
            rb.position = checkpointRotation.position;
            rb.rotation = checkpointRotation.rotation;
        }
        if (other.tag.Contains("Coin")){
            CoinsCollected++;
            other.gameObject.SetActive(false);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("wall")) {
            Vector3 upwardForceFromCollision = Vector3.Dot(collision.impulse, transform.up) * transform.up;
            rb.AddForce(-upwardForceFromCollision, ForceMode.Impulse);
        }
    }
}
