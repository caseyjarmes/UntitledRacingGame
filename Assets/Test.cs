using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Test : MonoBehaviour
{
    MainControl controls;
    //Transform objec;
    private Rigidbody ship;
    public float speed;
    public float turningspeed;
    private Vector3 localvelocity;
    public float Amp;
    public float howerspeed;
    private Vector3 sinfunction;

    private void FixedUpdate()
    {
        
        //sinfunction.y = Mathf.Sin(Time.realtimeSinceStartup * howerspeed) *Amp;
        //ship.transform.position = sinfunction;
    }
    private void Awake()
    {
        controls = new MainControl();
        ship = GetComponent<Rigidbody>();
        sinfunction = transform.position;
    }
    public void MoveRight()
    {
        ship.AddTorque(Vector3.up*turningspeed);
        
        Debug.Log("Moving Object to the Right!");
    }
    public void MoveLeft()
    {
        ship.AddTorque(-Vector3.up*turningspeed);
        Debug.Log("Moving Object to the Left!");
    }
    public void Accelerate()
    {
        ship.AddRelativeForce(new Vector3(Vector3.forward.x,0,Vector3.forward.z)*speed*10);
        transform.InverseTransformDirection(localvelocity);
        localvelocity.x = 0;
        ship.velocity = transform.TransformDirection(localvelocity);

    }
    public void Deccelerate()
    {
        ship.AddRelativeForce(new Vector3(-Vector3.forward.x, 0, -Vector3.forward.z) * speed);
    }
    public void OnMovementLeftStick(InputAction.CallbackContext value)
    {
        Vector2 input = value.ReadValue<Vector2>();
        ship.rotation = Quaternion.AngleAxis(input.x,Vector3.right);
    }
}
