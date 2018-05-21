using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public bool notswung;
    public GameObject box;
    internal object onClick;

    // Use this for initialization
    void Start ()
    {
        box.SetActive(true);		
	}

    private void OnTriggerEnter(Collider other)
    {
        box.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
