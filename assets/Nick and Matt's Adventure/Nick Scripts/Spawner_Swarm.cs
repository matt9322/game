using UnityEngine;
using System.Collections;

public class Spawner_Swarm : MonoBehaviour {
    public float Thrust = 20;
    public Rigidbody Square;
    public Rigidbody NewSquare;
    public GameObject Scale;

    
    void Start ()
    {
    Scale = GetComponent<GameObject>();
	Square = GetComponent<Rigidbody>();
    }
	
	
	void Update ()
    {
        NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
        
    }
    void OnCollisionEnter (Collision other)
    {
        
            
            
            
    }
}
