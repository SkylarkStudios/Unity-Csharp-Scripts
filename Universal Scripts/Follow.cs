using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
  public GameObject target;
// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;
        transform.Translate(new Vector3(0, 10, -30));
    }
}
