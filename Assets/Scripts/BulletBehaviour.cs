using System.Collections;
using System.Collections.Generic;
using Resources;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
	[SerializeField] private floatVariable shotSpeed;
	[SerializeField] public Vector3 velocity;
	[SerializeField] private float timeToLive = 2;

	[SerializeField]
	public GameObject Explosion;
	// Update is called once per frame
	void Update ()
	{
		if (timeToLive < 0)
		{
			Time.timeScale = 1;
			var exp = Instantiate(Explosion, transform.position, Quaternion.identity);
			var ps = exp.GetComponent<ParticleSystem>().main.duration;
			Destroy(exp, ps);
			Destroy(gameObject);
		}
		
		transform.position += velocity * shotSpeed.Value;
		timeToLive -= Time.fixedDeltaTime;
	}
}