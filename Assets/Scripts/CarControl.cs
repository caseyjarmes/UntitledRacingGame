using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarControl : MonoBehaviour
{
    public int PlayerIndex;


    private MainControl inputs;
    public Rigidbody rb;
    private float BaseMass;
    public float speed;
    public float SpeedInformation { get; private set; }
    public float TorqueSpeed;
    private Vector3 groundNormal;

    public GameObject ship;
    public GameObject shipModel;

    private bool isOnGround;
    public LayerMask ground;

    private bool isOnGravel;
    public LayerMask gravel;

    public AudioSource boost;
    private bool boostStatus = false;
    private float duration = 60;

    public AudioSource crystal;
    public int CoinsCollected { get; private set; }

    private float RollingAngle = 30;

    private float movementValue;
    public float MovementValue { get => movementValue; set => movementValue =value; }
    private float driftValue;
    public float DriftValue { get => driftValue; set => driftValue = value; }
    private float trottleValue;
    public float TrottleValue { get => trottleValue; set => trottleValue = value; }
    private bool wasWeaponUsed;
    public bool WasWeaponUsed { get => wasWeaponUsed; set => wasWeaponUsed = value; }

    public bool HasWeapon;

    Transform checkpointRotation;
    
    private void Awake()
    {
        //inputs = new MainControl();

        shipModel = ship.transform.GetChild(0).gameObject;
        BaseMass = rb.mass;
        
    }
    //private void OnEnable()
    //{
    //    inputs.Enable();
    //}
    //private void OnDisable()
    //{
    //    inputs.Disable();
    //}
    void Start()
    {        
        rb = GetComponentInChildren<Rigidbody>();
        BaseMass = rb.mass;
        CoinsCollected = 0;
        
    }
    public int GetPlayerIndex()
    {
        return PlayerIndex;
    }
    //public void SetfloatMovement(float value)
    //{
    //    movementValue = value;
    //}
    //public void SetDriftMovement(float value)
    //{
    //    DriftValue = value;
    //}
    //public void SetTrottleInput(float value)
    //{
    //    TrottleValue = value;
    //}
    public void SetWeaponUseInput()
    {
        WasWeaponUsed = true;
    }

    void FixedUpdate()
    {          
        
        Ray ray = new Ray(rb.position, Vector3.down);
        RaycastHit hitinfo;        
        isOnGravel = Physics.Raycast(ray, out hitinfo, 2f, gravel);     
        isOnGround = Physics.Raycast(ray, out hitinfo, 2f, ground);
        //LimitRotations();

        Debug.Log(ReturnVehicleVelocity(rb.velocity.magnitude));
        SpeedInformation = ReturnVehicleVelocity(rb.velocity.magnitude);
        Speed();
        TurningAndTilt();
        //Weapon();
        if (isOnGround || isOnGravel) 
        {
            groundNormal = hitinfo.normal.normalized;
        }
        else
        {        
            LimitRotations();
            groundNormal = Vector3.up;
            rb.AddRelativeForce(-groundNormal * 35, ForceMode.Acceleration);
        }        
    }
    private void Speed()
    {
        //This system is intended to keep the velocity of the
        //object only foward facing of the vehicle
        //If you turn it on drastically increase the speed to normalize it
        //= inputs.VehicleControl.TrottleControl.ReadValue<float>(); 
        float valueSpeed = TrottleValue;    
        if (boostStatus && valueSpeed > 0)
        {
            //1.25 is the modifier
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed * 2.5f);
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
        if (valueSpeed > 0)
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed);
        }
        else if (valueSpeed < 0)
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed * .25f);
        }
    }
    private void TurningAndTilt()
    {
        //Keep adjustable torque value Very small hundredths or thousands
        float valueturn = MovementValue;
        rb.AddRelativeTorque(new Vector3(0, valueturn) * TorqueSpeed);

        //inputs.VehicleControl.Drifting.ReadValue<float>();
        float driftvalue = DriftValue;
        rb.AddRelativeTorque(new Vector3(0, driftvalue * TorqueSpeed * 1.25f));
        
        //For the Turning of the ship model separately from the rest of the gameobject without also affecting the levitation points
        float rollEluerValue = RollingAngle * -valueturn;
        Quaternion modelRotation = shipModel.transform.rotation * Quaternion.Euler(0f, 0f, rollEluerValue);
        shipModel.transform.rotation = Quaternion.Lerp(shipModel.transform.rotation, modelRotation, Time.deltaTime * 2.5f);
        
        //To deal with physics issues caused by the levitation points reverts the parent to normal orientation
        Vector3 projection = Vector3.ProjectOnPlane(transform.forward, groundNormal);
        Quaternion rotations = Quaternion.LookRotation(projection, groundNormal);
        shipModel.transform.rotation = (Quaternion.Lerp(shipModel.transform.rotation, rotations, Time.deltaTime * 5f));

    }
    private void Weapon()
    {
        bool weaponbutton = WasWeaponUsed;
        //Check if player pressed the button to shoot weapon
        if (weaponbutton && HasWeapon)
        {
            //insert weapon spawn instantiate
            weaponbutton = false;
        }
            else
                    return;
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
                if (CoinsCollected < 10)
                {

                    rb.mass += .20f;
                }                    
                CoinsCollected++;
                    other.gameObject.SetActive(false);
               
                crystal.Play();
                VoManager.voMan.PlayVoPickup();
                //INSERT COIN SOUND THING
                break;
            case "Boost":
                boostStatus = true;
                //BOOSTING SOUND INSERT HERE
                if(!boost.isPlaying)
                boost.Play();
                break;
            default:
                break;
        }
    }
    
    //private void OnCollisionStay(Collision collision)
    //{
    //    if(collision.gameObject.layer == LayerMask.NameToLayer("wall")) {
    //        Vector3 upwardForceFromCollision = Vector3.Dot(collision.impulse, transform.up) * transform.up;
    //        rb.AddForce(-upwardForceFromCollision, ForceMode.Impulse);
    //        rb.velocity = rb.velocity*.999999f;
    //    }

    //}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Boost")
        {
            duration = 0;
        }
    }
    private float ReturnVehicleVelocity(float value)
    {
        //rb.velocity.magnitude
        //For ui make this value bigger because its rather tiny for the sense of speed
        return (float)Math.Round((decimal)(value * 10), 0);
    }
}
