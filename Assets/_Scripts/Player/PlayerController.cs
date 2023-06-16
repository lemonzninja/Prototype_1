using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    void Update()
    {
        // Move the Vehicle forward
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
