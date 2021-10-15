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
        float valueturn = inputs.VehicleControl.Movement.ReadValue<float>();
        //Keep adjustable torque value Very small hundredths or thousands
        rb.AddRelativeTorque(new Vector3(0, valueturn)*TorqueSpeed);
        float valueSpeed = inputs.VehicleControl.TrottleControl.ReadValue<float>();
        rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * valueSpeed);

        //This system is intended to keep the velocity of the
        //object only foward facing of the vehicle
        //If you turn it on drastically increase the speed to normalize it

        //transform.InverseTransformDirection(localvelocity*.5f);
        //localvelocity.x = 0;
        //rb.velocity = transform.TransformDirection(localvelocity);

    }
    private void ClampVehicleRotation()
    {
        xClampAxisAngle = Mathf.Clamp(xClampAxisAngle, -45, 45);
        zClampAxisAngle = Mathf.Clamp(zClampAxisAngle, -30, 30);
        rb.transform.rotation = Quaternion.Euler(xClampAxisAngle, 0, 0);
        rb.transform.rotation = Quaternion.Euler(0, 0, zClampAxisAngle);
        
        //rb.transform.rotation = Quaternion.Lerp(rb.transform.rotation, toclamp, Time.deltaTime,.75);

    }
}
