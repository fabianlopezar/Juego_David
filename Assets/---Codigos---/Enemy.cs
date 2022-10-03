using UnityEngine;
public class Enemy : MonoBehaviour {

	public GameObject deathEffect;
	public float health = 4f;
	public static int EnemiesAlive = 0;
	public AudioSource hit;

	public Sprite goliatMuerto;
	public GameObject goliat;
	public Trigger acti;

	void Start ()
	{
		EnemiesAlive++;
		hit = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			hit.Play();
			Die();
		}
		
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);

		EnemiesAlive--;
		if (EnemiesAlive <= 0) 
		{
			goliat.gameObject.GetComponent<SpriteRenderer>().sprite = goliatMuerto;
			acti.act = false;
			Debug.Log("LEVEL WON!");
		
	    }
		Destroy(gameObject);
	}
}
