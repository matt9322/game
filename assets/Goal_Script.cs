using UnityEngine;
using System.Collections;

public class Goal_Script : MonoBehaviour {
    public GameObject Touching;
    public GameObject Particle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void OnTriggerEnter (Collider other)
    {
        GameObject Particle;
        Particle = Instantiate(Touching, other.transform.position, other.transform.rotation) as GameObject;
        if (other.gameObject.CompareTag("Coin"))
        {
            

            Debug.Log("GOOOOOOOOOOAAAAAAAAAAAAAL");
            Destroy(other.gameObject);
        }
    }
}
