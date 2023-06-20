using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 45;
    
    public float horizontalInput;
    public float forwardInput;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    
        // slide the vehicle left and right
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}