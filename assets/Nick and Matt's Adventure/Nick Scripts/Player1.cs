using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player1 : MonoBehaviour {
    public Rigidbody CharacterForce;
    CharacterController Controller1;
    public float Grav;
    public float moveSpeed = 10f;
    public float Thrust;
    public Vector3 CameraAngle;
    public GameObject center;
    public Camera cam;
    public GameObject Rail;
    public int Score = 0;
    public bool InAir;
    public int JumpPower = 5;
    Vector3 movement = Vector3.zero;
    public float maxSpeed = 100;
    bool RailTouch = false;
    public int bumperForce = 10;
    public Text myScore;
    public AudioSource source;
    public AudioClip BounceSound;
    public AudioClip GrindSound;
    public Text myHealth;
    public int Health = 100;
    public float MouseF = 1000f;


   
    void Start () {
        CharacterForce = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        Controller1 = GetComponent<CharacterController>();
        InAir = false;
    }
    void OnMouseDown()
    {
        CharacterForce.AddForce(-transform.forward * MouseF, ForceMode.Acceleration);
    }

    void OnCollisionStay(Collision collisionInfo)
    {

        InAir = false;
         if (collisionInfo.gameObject.CompareTag("Rail2"))
        {
            //Debug.Log("RAILING TWO HIT!");
            //CharacterForce.AddForce(Rail.transform.forward * 500, ForceMode.Force);
            ///if (collisionInfo.gameObject.CompareTag("Rail1"))
            // {
            //    Debug.Log("RAILING ONE HIT!");
            //}
            RailTouch = true;
            CharacterForce.AddForce(collisionInfo.transform.forward * 10, ForceMode.Impulse);
            
        }       

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Bouncer"))
        {
            source.PlayOneShot(BounceSound);
            CharacterForce.AddForce(collisionInfo.contacts[0].normal * bumperForce, ForceMode.Impulse);
        }
        if (collisionInfo.gameObject.CompareTag("Enemy"))
        {
            Health--;
        }
    }
    void OnCollisionExit(Collision collisionInfo)
    {
            InAir = true;
        RailTouch = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Coin"))
        {
            Score = (Score + 1);
        }
     
       }
    void Update () {
        
        myScore.text = "Score: " + Score;
        myHealth.text = "Health: " + Health;
        Debug.Log(CharacterForce.velocity);
        if (RailTouch == true)
        {
            //CharacterForce.AddForce(Rail.transform.forward * 500, ForceMode.Force);
        }
        if (InAir)
        {
            //Disables movement while in the air.
            if (Input.GetKey(KeyCode.Space))
                CharacterForce.AddForce(cam.transform.up * 0, ForceMode.Impulse);
            if (Input.GetKey(KeyCode.W))
                CharacterForce.AddForce(cam.transform.up * 0, ForceMode.Impulse);
            if (Input.GetKey(KeyCode.A))
                CharacterForce.AddForce(cam.transform.up * 0, ForceMode.Impulse);
            if (Input.GetKey(KeyCode.S))
                CharacterForce.AddForce(cam.transform.up * 0, ForceMode.Impulse);
            if (Input.GetKey(KeyCode.D))
                CharacterForce.AddForce(cam.transform.up * 0, ForceMode.Impulse);
            
            //Control air Speed
            if (CharacterForce.velocity.magnitude > 300)
            {
                CharacterForce.velocity = Vector3.ClampMagnitude(CharacterForce.velocity, 300f);
                
            }
        }

        if (!InAir)
        {
            if (Input.GetKey(KeyCode.Space))
                CharacterForce.AddForce(cam.transform.up * JumpPower, ForceMode.Impulse);
            if (Input.GetKey(KeyCode.S))
                CharacterForce.AddForce(cam.transform.forward * Thrust * -1, ForceMode.Impulse);
            if (Input.GetKey(KeyCode.W))
                CharacterForce.AddForce(cam.transform.forward * Thrust, ForceMode.Impulse);
            //Control Ground Speed
            if (CharacterForce.velocity.magnitude > 300)
            {
                CharacterForce.velocity = Vector3.ClampMagnitude(CharacterForce.velocity, 300f);
                
            }
        }

        //Camera's center point
        center.transform.position = transform.position;

        CharacterForce.AddForce(Vector3.down * Grav, ForceMode.Impulse);
        
        //Character movement
        
        
    }
}
