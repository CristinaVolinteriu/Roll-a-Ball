using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    //public GameObject gameObject;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space"))
        {
            Vector2 v = new Vector2(0.0f, 4);
            rb.AddForce(v);
        }
        else
        {
            Vector2 v1 = new Vector2(0, -4);
            rb.AddForce(v1);
        }
	}
}
