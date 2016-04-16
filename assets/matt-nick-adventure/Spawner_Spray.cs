using UnityEngine;
using System.Collections;

public class Spawner_Spray : MonoBehaviour {
    public float Thrust = 20;
    public Rigidbody Square;
    public Rigidbody NewSquare;

    // Use this for initialization
    void Start ()
    {
	Square = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //Debug.Log("WORKING!");
    }
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
            Square.AddForce(transform.up * Thrust, ForceMode.Impulse);
            
        }
    }
}
