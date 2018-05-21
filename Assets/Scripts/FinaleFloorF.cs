using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleFloorF : MonoBehaviour {

    public AudioClip ding;

	// Use this for initialization
	void Start ()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = ding;
		
	}

    void OnCollisionEnter(Collision col)
    {
        GetComponent<AudioSource>().Play();
        if (col.gameObject.name == "F")
        {
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
