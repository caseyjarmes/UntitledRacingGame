using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevitationSystem : MonoBehaviour
{
    private Rigidbody rb;

    public float restLength;
    public float springTravel;
    public float springStiffness;
    public float damperStiffness;

    private float minLength;
    private float maxLength;
    private float toDamperLength;

    private float springLength;
    private float springForce;
    private float damperForce;

    private float springVelocity;

    private Vector3 suspensionForce;

    public float wheelRadius;
    Vector3 groundNormal;

    public bool EdgePoint;

    public LayerMask ground;

    private bool isOnGround;
    void Start()
    {
        //rb = transform.root.GetComponent<Rigidbody>();
        rb = transform.root.GetComponentInChildren<Rigidbody>();
        minLength = restLength - springTravel;
        maxLength = restLength + springTravel;

    }


    void FixedUpdate()
    {
        Ray ray = new Ray(rb.position, -rb.transform.up); 
        RaycastHit hitInfo;
        isOnGround = Physics.Raycast(ray, out hitInfo, 2f, ground);
        if(isOnGround)
        {
            if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, maxLength + wheelRadius, ground))
            {
                toDamperLength = springLength;
                springLength = Mathf.Clamp(springLength, minLength, maxLength);

                springLength = hit.distance - wheelRadius;
                springVelocity = (toDamperLength - springLength) / Time.fixedDeltaTime;


                springForce = springStiffness * (restLength - springLength);
                damperForce = damperStiffness * springVelocity;

                suspensionForce = (springForce + damperForce) * transform.up;
                if(!EdgePoint)
                    rb.AddForceAtPosition(suspensionForce, hit.point);
                else
                    rb.AddForceAtPosition(suspensionForce/2, hit.point);

            }
        }
        //isOnGround = false;
        //Quaternion bodyRotation = transform.rotation * Quaternion.Euler(0f, 0f, 60);

        //rb.rotation = Quaternion.Lerp(rb.rotation, bodyRotation, Time.deltaTime * 10f);
    }

}
