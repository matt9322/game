using UnityEngine;
using System.Collections;

public class Spawner_Spray1 : MonoBehaviour {
    public float Thrust = 20;
    public Rigidbody Square;
    public Rigidbody NewSquare;
    public bool SpawnMe = false;

    
    void Start ()
    {
        SpawnMe = false;
	Square = GetComponent<Rigidbody>();
    }
	
	
	void Update ()
    {
        Debug.Log(SpawnMe);
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
