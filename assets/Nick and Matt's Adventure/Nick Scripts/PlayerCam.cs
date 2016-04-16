using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour {
    public GameObject Player;
    //private Vector3 Offset;
    
	// Use this for initialization
	void Start () {
       // Offset = transform.position - Player.transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player.transform);
        //transform.position = Player.transform.position + Offset;
        if (Input.GetKey(KeyCode.A))
        {
           // transform.RotateAround(Player.transform.position, Vector3.down, Time.deltaTime * 80);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.RotateAround(Player.transform.position, Vector3.up, Time.deltaTime * 80);
        }

    }
}
