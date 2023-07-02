using UnityEngine;

public class MoveForward : MonoBehaviour
{
	[SerializeField] private float speed = 15f;
	
	void Update()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}