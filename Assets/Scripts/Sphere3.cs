using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("Cylinder1"))
        {
            Destroy(col.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
