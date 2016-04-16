using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Ground"))
        {

            Destroy(gameObject);



        }


    }


void Update () {
	
	}
}
