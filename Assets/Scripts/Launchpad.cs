using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchpad : MonoBehaviour {

    float launchpad = 20;
    public Rigidbody actor;

	// Use this for initialization
	void Start ()
    {
        actor = GetComponent<Rigidbody>();
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LaunchPad")
        {
            actor.velocity = new Vector3(launchpad, launchpad,0);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
