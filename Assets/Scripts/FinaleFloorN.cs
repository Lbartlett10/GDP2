using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleFloorN : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "N")
        {
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
