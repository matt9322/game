using UnityEngine;
using System.Collections;

public class FollowingScript : MonoBehaviour {
    public Rigidbody target;
    public float smooth = 5.0f;

    // Use this for initialization
    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = Vector3.Lerp(
                transform.position, target.position,
                Time.deltaTime * smooth);
        }
    }
}
