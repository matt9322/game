using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour {
    //public GameObject Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-3,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, 0);
        }
    }
}

