using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour {

    public float speed = 100f;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        while (col.gameObject.name.Contains("Sphere"))
        {
            transform.Rotate(Vector3.down, speed * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update ()
    {
        
    }
}
