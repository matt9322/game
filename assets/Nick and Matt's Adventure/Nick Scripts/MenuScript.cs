using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
       
             
        
	// Use this for initialization
	void Start () {
       
    }
    void OnMouseDown ()
    {
       EditorSceneManager.LoadScene("Level1"); 
    }
    // Update is called once per frame
    void Update () {
	
	}
}
