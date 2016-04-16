using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
    public GameObject Bullet;
    public GameObject Gun;
    public Rigidbody Bullets;
    public float bulletSpeed;

	// Use this for initialization
	void Start () {
	
	}


        
        
  	
	// Update is called once per frame
	void Update () {
	if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody Bullets;
            Bullets = Instantiate(Bullet, Gun.transform.position, Gun.transform.rotation) as Rigidbody;
            
        }
	}
}
