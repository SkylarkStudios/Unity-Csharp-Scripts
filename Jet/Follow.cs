using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = GameObject.Find("AircraftJet").transform.position;
        transform.rotation = GameObject.Find("AircraftJet").transform.rotation;
        transform.Translate(new Vector3(0, 10, -30));
    }
}
