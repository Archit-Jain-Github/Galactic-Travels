using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    //unity controls and constants input
    public float accelerationMod;
    public float xAxisSensitivity;
    public float yAxisSensitivity;
    public float deccelerationMod;
    public string forwards;
    public string backwards;
    public string left;
    public string right;
    public string up;
    public string down;
    public string reset;
    public float resetSpeed;


    private Vector3 moveSpeed;
    private bool xVector;
    private bool yVector;
    private bool zVector;

    public Transform resetpos;

    void Start()
    {
        moveSpeed = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {

        xVector = false;
        yVector = false;
        zVector = false;

        Vector3 acceleration = new Vector3();

        //mouse input
        float rotationHorizontal = xAxisSensitivity * Input.GetAxis("Mouse X");
        float rotationVertical = yAxisSensitivity * Input.GetAxis("Mouse Y");


        transform.localEulerAngles = transform.localEulerAngles + new Vector3(-rotationVertical, rotationHorizontal, 0);


        if (Input.GetKey(forwards))
        {

            xVector = true;
            acceleration += transform.forward;

        }

        if (Input.GetKey(reset))
        {
            var delta = resetpos.position - transform.position;
            transform.position = delta * Time.deltaTime * resetSpeed;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }

        if (Input.GetKey(left))
        {

            zVector = true;
            acceleration += -transform.right;
        }

        if (Input.GetKey(backwards))
        {

            xVector = true;
            acceleration += -transform.forward;
        }

        if (Input.GetKey(right))
        {

            zVector = true;
            acceleration += transform.right;
        }

        if (Input.GetKey(up))
        {

            yVector = true;
            acceleration += transform.up;
        }

        if (Input.GetKey(down))
        {

            yVector = true;
            acceleration += -transform.up;
        }


        if (!xVector)
        {

            if (Math.Abs(moveSpeed.x) < deccelerationMod)
            {
                moveSpeed = new Vector3(0, moveSpeed.y, moveSpeed.z);
            }
            else
            {
                moveSpeed = new Vector3(moveSpeed.x - deccelerationMod * Math.Sign(moveSpeed.x), moveSpeed.y, moveSpeed.z);
            }
        }

        if (!yVector)
        {
            if (Math.Abs(moveSpeed.y) < deccelerationMod)
            {
                moveSpeed = new Vector3(moveSpeed.x, 0, moveSpeed.z);
            }
            else
            {
                moveSpeed = new Vector3(moveSpeed.x, moveSpeed.y - deccelerationMod * Math.Sign(moveSpeed.y), moveSpeed.z);
            }
        }

        if (!zVector)
        {

            if (Math.Abs(moveSpeed.z) < deccelerationMod)
            {
                moveSpeed = new Vector3(moveSpeed.x, moveSpeed.y, 0);
            }
            else
            {
                moveSpeed = new Vector3(moveSpeed.x, moveSpeed.y, moveSpeed.z - deccelerationMod * Math.Sign(moveSpeed.z));
            }
        }



        acceleration = transform.TransformVector(acceleration);
        acceleration.Normalize();
        acceleration *= accelerationMod;
        moveSpeed += acceleration;

        transform.Translate(moveSpeed);
    }
}

