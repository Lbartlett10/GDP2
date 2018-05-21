using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult2 : MonoBehaviour {

    public float speed = 50f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("Cube"))
        {
            speed = 0f;
        }
        else
        {
            speed = 50f;
        }
    }
}
