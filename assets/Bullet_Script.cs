using UnityEngine;
using System.Collections;

public class Bullet_Script : MonoBehaviour {
    public Rigidbody BulletModel;
    public float bulletSpeed = 100f;
	// Use this for initialization
	void Start () {
        BulletModel = GetComponent<Rigidbody>();

        BulletModel.AddForce(transform.forward * bulletSpeed * 1, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
