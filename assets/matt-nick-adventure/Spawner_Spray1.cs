using UnityEngine;
using System.Collections;

public class Spawner_TrigSwarm : MonoBehaviour {
    public float Thrust = 20;
    public Rigidbody Square;
    public Rigidbody NewSquare;
    bool SpawnMe;

    
    void Start ()
    {
        SpawnMe = false;
	Square = GetComponent<Rigidbody>();
    }
	
	
	void Update ()
    {
        if (SpawnMe)
        {
            NewSquare = Instantiate(NewSquare, transform.position, transform.rotation) as Rigidbody;
        }
        if(!SpawnMe)
        {
            
        }

    }
    void OnCollisionEnter (Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            SpawnMe = true;
           
            

        }


    }
}
