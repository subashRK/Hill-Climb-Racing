using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour
{
    float horizontalMovement;

    public float speed = 100f;
    public WheelJoint2D backWheelJoint2D;
    public WheelJoint2D frontWheelJoint2D;
    public Rigidbody2D rb;
    public float torque = 10;

    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        if (horizontalMovement == 0f) 
        {
            backWheelJoint2D.useMotor = false;
            frontWheelJoint2D.useMotor = false;
        }
        else 
        {
            JointMotor2D backWheelMotor = new JointMotor2D { motorSpeed = -horizontalMovement, maxMotorTorque = 1000000 };

            backWheelJoint2D.motor = backWheelMotor;
            frontWheelJoint2D.motor = backWheelMotor;

            rb.AddTorque(horizontalMovement / 100f * torque * Time.fixedDeltaTime);
        }
        
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + 1, -10);
    }
}
