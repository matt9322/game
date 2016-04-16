using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
    public float speed = 20f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(2, 0, 0);
    }
    void OnTriggerEnter (Collider Coin)
    {
        if (Coin.tag == ("Player"))
        {
            Destroy(gameObject);
        }
    }

}
