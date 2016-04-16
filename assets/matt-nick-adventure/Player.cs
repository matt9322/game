using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float speed;
    public int Score;
    public Rigidbody Bullet;
    public GameObject BulletSpawn;
    // Use this for initialization
	void Start ()
    {
        Bullet = GetComponent<Rigidbody>();
        Score = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		Debug.Log (Score);
        if (Input.GetButtonDown("Fire1"))
        {
           // Rigidbody BulletNew;
            //BulletNew = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody;
           // Bullet.AddForce(transform.up * speed, ForceMode.Impulse);
        }
	}

	void OnCollisionEnter (Collision other)
	{
        if (other.gameObject.CompareTag("Pickup"))
        {
            Score++;
            Destroy(other.gameObject);
        }

	}
}
