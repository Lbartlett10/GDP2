using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleFloorI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "I")
        {
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
