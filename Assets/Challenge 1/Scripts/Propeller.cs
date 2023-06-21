using UnityEngine;

public class Propeller : MonoBehaviour
{
	[SerializeField] private float rotationSpeed = 360f;
	
	void Update()
	{
		transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
	}
}