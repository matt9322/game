using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMouse : MonoBehaviour {
    public Rigidbody CharacterForce;
    CharacterController Controller1;
    public float Grav;
    public Vector3 CameraAngle;
    public GameObject center;
    public Camera cam;
    public bool InAirs = false;
    //Vector3 movement = Vector3.zero;
    public float maxSpeed = 100;
    public float MouseFforward = 1000f;
    public float MouseFup = 1000f;
    public Camera camer;
    public int Gravit;


    void Start () {
        CharacterForce = GetComponent<Rigidbody>();
        Controller1 = GetComponent<CharacterController>();
        InAirs = false;
    }
    void OnMouseDown()
    {
        if (InAirs)
        {
            CharacterForce.AddForce(camer.transform.forward * 0, ForceMode.Impulse);
            CharacterForce.AddForce(camer.transform.up * 0, ForceMode.Impulse);
        }
        if (!InAirs)
        {
            CharacterForce.AddForce(camer.transform.forward * MouseFforward, ForceMode.Impulse);
            CharacterForce.AddForce(camer.transform.up * MouseFup, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Ground"))
        {
            InAirs = false;
        }

    }
   
   void Update () {
        InAirs = false;


        CharacterForce.AddForce(transform.up * Gravit * -1, ForceMode.Impulse);
        //Control air Speed
        if (CharacterForce.velocity.magnitude > 300)
            {
                CharacterForce.velocity = Vector3.ClampMagnitude(CharacterForce.velocity, 300f);
            }
    

        center.transform.position = transform.position;

        CharacterForce.AddForce(Vector3.down * Grav, ForceMode.Impulse);


        //Control Ground Speed
        if (CharacterForce.velocity.magnitude > 300)
            {
                CharacterForce.velocity = Vector3.ClampMagnitude(CharacterForce.velocity, 300f);
                
            }
        }
            
        
    }

