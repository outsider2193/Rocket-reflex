using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rbody;
    [SerializeField] float Thrust = 0.0f;
    [SerializeField] float RotationThrust = 0.0f;
    void Start()
    {

        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrusting();
    }

    void Thrusting()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rbody.AddRelativeForce(Vector3.up * Thrust * Time.deltaTime);
        }
        Rotating();
    }
    void Rotating()
    {
        rbody.freezeRotation = true;
        rbody.freezeRotation = false;
        { }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back * RotationThrust * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * RotationThrust * Time.deltaTime);
        }
    }
}

