using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 _offset = new Vector3(0, 5, -7);

    private void LateUpdate()
    {   
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + _offset;
    }
}