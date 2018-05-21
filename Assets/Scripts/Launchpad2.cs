using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchpad2 : MonoBehaviour {

    float launchpad = 20;
    public Rigidbody actor;

    // Use this for initialization
    void Start()
    {
        actor = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LaunchPad2")
        {
            actor.velocity = new Vector3(0, launchpad, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
