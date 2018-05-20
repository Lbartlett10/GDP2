using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("FunnelPlatform"))
        {
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
