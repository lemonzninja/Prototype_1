using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // the plane's forward speed
    [SerializeField] private float speed;
    // the plane's rotation speed
    [SerializeField] private float rotationSpeed;
    
    // the user's vertical input
    private float _verticalInput;

    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * _verticalInput * Time.deltaTime);
    }
}