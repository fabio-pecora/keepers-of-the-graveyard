using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float speed = 20f;
	public int damage = 2;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
		if (collider.gameObject.name == "Enemy")
		{
			//If the GameObje
			Enemy enemy = collider.GetComponent<Enemy>();
			Destroy(gameObject);
			if (enemy.health != 0)
            {
				enemy.TakeDamage(damage);
            }
		}

	}

}