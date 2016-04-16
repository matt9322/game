using UnityEngine;
using System.Collections;

public class MouseForce : MonoBehaviour {
    public float MouseF = 1000f;
    public Rigidbody Player;
    // Use this for initialization
	void Start () {
        Player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnMouseDown()
    {
        Player.AddForce(transform.forward * MouseF, ForceMode.Impulse);
    }
}
