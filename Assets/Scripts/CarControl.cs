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
    private Vector3 groundNormal;

    public GameObject ship;
    public GameObject shipModel;

    private bool isOnGround;
    public LayerMask ground;

    private bool isOnGravel;
    public LayerMask gravel;

    private bool boostStatus = false;
    private float duration = 0;


    public static int CoinsCollected { get; private set; }

    private float RollingAngle = 30;
    
        
    Transform checkpointRotation;
    
    private void Awake()
    {
        inputs = new MainControl();
        rb = GetComponent<Rigidbody>();
        shipModel = ship.transform.GetChild(0).gameObject;
        
        
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
        Ray ray = new Ray(rb.position, Vector3.down);
        RaycastHit hitinfo;     
        isOnGround = Physics.Raycast(ray, out hitinfo, 2f, ground);
        isOnGravel = Physics.Raycast(ray, out hitinfo, 2f, gravel);
        Debug.Log(ReturnVehicleVelocity());
        Speed();
        TurningAndTilt();
        if (isOnGround || isOnGravel) 
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
    private void Speed()
    {           
        //This system is intended to keep the velocity of the
        //object only foward facing of the vehicle
        //If you turn it on drastically increase the speed to normalize it         
        float valueSpeed = inputs.VehicleControl.TrottleControl.ReadValue<float>();    
        if (boostStatus)
        {
            //1.25 is the modifier
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed * 3f);
            if(duration < 60)
            {
                duration++;
            }
            else
            {
                boostStatus = false;
                duration = 0;
            }
            return;
        }
        if (isOnGravel)
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed * .5f);
            return;
        }

        rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed);

    }
    private void TurningAndTilt()
    {
        //Keep adjustable torque value Very small hundredths or thousands
        float valueturn = inputs.VehicleControl.Movement.ReadValue<float>();
        rb.AddRelativeTorque(new Vector3(0, valueturn) * TorqueSpeed);
        float rollEluerValue = RollingAngle * -valueturn;
        Quaternion modelRotation = shipModel.transform.rotation * Quaternion.Euler(0f, 0f, rollEluerValue);
        shipModel.transform.rotation = Quaternion.Lerp(shipModel.transform.rotation, modelRotation, Time.deltaTime * 2.5f);
        Vector3 projection = Vector3.ProjectOnPlane(transform.forward, groundNormal);
        Quaternion rotations = Quaternion.LookRotation(projection, groundNormal);
        shipModel.transform.rotation = (Quaternion.Lerp(shipModel.transform.rotation, rotations, Time.deltaTime * 5f));

    }
    private void LimitRotations()
    {
        Vector3 projection = Vector3.ProjectOnPlane(transform.forward, groundNormal);
        Quaternion rotations = Quaternion.LookRotation(projection, groundNormal);
        rb.MoveRotation(Quaternion.Lerp(rb.rotation, rotations, Time.deltaTime * 1f));
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Checkpoint":            
                checkpointRotation.rotation = other.transform.rotation;
                break;
            case "Coin":
                CoinsCollected++;
                other.gameObject.SetActive(false);
                break;
            case "Boost":
                boostStatus = true;
                break;
            default:
                break;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("wall")) {
            Vector3 upwardForceFromCollision = Vector3.Dot(collision.impulse, transform.up) * transform.up;
            rb.AddForce(-upwardForceFromCollision, ForceMode.Impulse);
        }
    }
    public float ReturnVehicleVelocity()
    {
        //For ui make this value bigger because its rather tiny for the sense of speed
        return rb.velocity.magnitude;
    }
}
