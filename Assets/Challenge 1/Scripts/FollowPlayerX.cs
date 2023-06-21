using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    [SerializeField] private Vector3 offset = new Vector3(30, 0, 10);
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}