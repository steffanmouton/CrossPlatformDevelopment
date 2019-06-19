using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
	[Header("Variables")]
	[SerializeField] public Vector3 moveVector;
	[SerializeField] private floatVariable speed;
	[SerializeField] private Vector3 threeDLocation;
	
	[SerializeField] private float tilt = 10;
	
	
	[Header("Transforms")]
	[SerializeField] private Transform turretTransform;
	[SerializeField] private Transform barrelTipTransform;

	[Header("Component References")]
	[SerializeField] private GameObject normalBullet;
	[SerializeField] private Camera cameraRef;

	[SerializeField] private floatVariable bulletSpeed;
	
	public Vector3 Vector
	{
		get { return moveVector; }
	}

	public floatVariable Speed
	{
		get { return speed; }
	}

	// Use this for initialization
	// Update is called once per frame
	void Update ()
	{
		var mtoworld = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cameraRef.transform.position.z);
		threeDLocation = cameraRef.ScreenToWorldPoint(mtoworld);

		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
		
		moveVector = PlayerInput.Move.normalized * speed.Value;
		transform.position += moveVector * Time.deltaTime;
		
		turretTransform.LookAt(threeDLocation, Vector3.back);
		
		//transform.rotation = Quaternion.Euler(-90.0f - moveVector.y * - tilt, moveVector.x * - tilt, 0.0f );
		transform.rotation = Quaternion.Euler(-90.0f - moveVector.normalized.y * - tilt, moveVector.normalized.x * - tilt, 0.0f );
	}

	public GameObject Shoot()
	{
		var b = Instantiate(normalBullet);
		b.transform.position = barrelTipTransform.position;
		b.transform.forward = barrelTipTransform.forward;
		b.GetComponent<BulletBehaviour>().velocity = barrelTipTransform.forward;
		Time.timeScale = .1f;
		
		return b;
		
	}
}
// Camera.main.screentoworldposition
// transform.lookat