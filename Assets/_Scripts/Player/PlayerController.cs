using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20;
    private float _turnSpeed = 45;
    
    private float _horizontalInput;
    private float _forwardInput;
    
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera hoodCamera;
    public KeyCode switchKey;
    
    void Update()
    {
        // Get the user's input
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
        // Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);
        
        // Turn the vehicle left and right
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);
        
        /* slide the vehicle left and right
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        */
        
        // Switch between cameras
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        
    }
}