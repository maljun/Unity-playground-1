using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float v = Input.GetAxis("Vertical");
	    float h = Input.GetAxis("Horizontal");

        Debug.Log("V: " + v + "H: " + h);

        
	}
}
