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

    void Awake()
    {
        rb = transform.root.GetComponent<Rigidbody>();

        minLength = restLength - springTravel;
        maxLength = restLength + springTravel;
    }


    void FixedUpdate()
    {

        if(Physics.Raycast(transform.position,-transform.up, out RaycastHit hit, maxLength + wheelRadius))
        {
            toDamperLength = springLength;
            springLength = Mathf.Clamp(springLength, minLength, maxLength);

            springLength = hit.distance - wheelRadius;
            springVelocity = (toDamperLength - springLength) / Time.fixedDeltaTime;
            
            
            springForce = springStiffness * (restLength - springLength);
            damperForce = damperStiffness * springVelocity;

            suspensionForce = (springForce+damperForce) * transform.up;

            rb.AddForceAtPosition(suspensionForce,hit.point);
            
        }
    }
}
