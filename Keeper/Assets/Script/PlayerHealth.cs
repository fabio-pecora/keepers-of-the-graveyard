using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int health = 1000000000;


	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
			SceneManager.LoadScene("LosingScene");
		}
	}

	void Die()
	{
		Destroy(gameObject);
	}
}
