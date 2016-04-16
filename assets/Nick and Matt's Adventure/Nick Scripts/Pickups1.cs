using UnityEngine;
using System.Collections;

public class Pickups1 : MonoBehaviour {
    float Thrust;
    public Rigidbody Square;
	// Use this for initialization
	void Start ()
    {
	Thrust = Random.Range (5,20);
	Square = GetComponent<Rigidbody>();
        Square.AddForce(transform.up * Thrust * -1, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
    }
    void OnCollisionEnter (Collision other)
    {
		
    }
}
