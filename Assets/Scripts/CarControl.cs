using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarControl : MonoBehaviour
{
    private MainControl inputs;
    public Rigidbody rb;
    public float speed;
    private Vector3 localvelocity;
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
    void Update()
    {
        float valueturn = inputs.VehicleControl.Movement.ReadValue<float>();
        //Keep adjustable torque value Very small hundredths or thousands
        rb.AddRelativeTorque(new Vector3(0, valueturn)*.05f);
        float valueSpeed = inputs.VehicleControl.TrottleControl.ReadValue<float>();
        rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed);
        
        //This system is intended to keep the velocity of the
        //object only foward facing of the vehicle
        //If you turn it on drastically increase the speed to normalize it

        //transform.InverseTransformDirection(localvelocity*.5f);
        //localvelocity.x = 0;
        //rb.velocity = transform.TransformDirection(localvelocity);

    }
}
