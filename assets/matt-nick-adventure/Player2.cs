using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
    public Rigidbody CharacterForce;
    CharacterController Controller2;
    public float Grav;
    public float moveSpeed = 10f;
    public float Thrust;


    Vector3 movement = Vector3.zero;
    
    // Use this for initialization
	void Start () {
        CharacterForce = GetComponent<Rigidbody>();
        Controller2 = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        CharacterForce.AddForce(Vector3.down * Grav, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.DownArrow))
           CharacterForce.AddForce(Vector3.left * Thrust, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.UpArrow))
            CharacterForce.AddForce(Vector3.right * Thrust, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.LeftArrow))
            CharacterForce.AddForce(Vector3.forward * Thrust, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.RightArrow))
            CharacterForce.AddForce(Vector3.back * Thrust, ForceMode.Impulse);

    }
}
