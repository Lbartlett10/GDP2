using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour {

    public bool notswung;
    public GameObject box2;

    // Use this for initialization
    void Start()
    {
        box2.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        box2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
