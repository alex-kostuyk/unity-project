
using UnityEngine;

public class SmothTargetMoving : MonoBehaviour
{
	[SerializeField]
	private Transform target_point;
	[SerializeField]
	private float smootspeed = 10f;

	private Transform target;

	private void Start()
	{
		target = transform;
	}
	private void FixedUpdate()
	{

		target.position = Vector3.Lerp(target.position, target_point.position, smootspeed * Time.fixedDeltaTime);

	}
}
