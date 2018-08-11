using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuntReader : MonoBehaviour {
    int cscrewOn = 0;
    int loopOn = 0;
    public static string stuntName = "";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (NotTouching.lives > -1)
        {
            readLoop();
            readCorkscrew();
            // print(transform.rotation.x + "," + transform.rotation.y + "," + transform.rotation.z);
        }
    }
    void readLoop() {
       // print(transform.rotation.x +","+ transform.rotation.y+ "," + transform.rotation.z);
        if ((transform.rotation.x > 0.5 | transform.rotation.x < 0.5) & (loopOn == 0))
        {
            if (transform.rotation.x > 0.5) { loopOn = 1; }
            if (transform.rotation.x < 0.5) { loopOn = 2; }
        }
        if (!(loopOn == 0))
        {
            if (transform.rotation.x > 0.7 & loopOn == 2)
            {
                NotTouching.score += 300;
                loopOn = 0;
                stuntName = "Flip!";
            }
            if (transform.rotation.x < 0.3 & loopOn == 1)
            {
                NotTouching.score += 300;
                loopOn = 0;
                stuntName = "Backflip!";
            }
        }
    }
    void readCorkscrew() {
        if ((transform.rotation.z > 0.5 | transform.rotation.z < 0.5) & (cscrewOn == 0)) {
            if (transform.rotation.z > 0.5) { cscrewOn = 1; }
            if (transform.rotation.z < 0.5) { cscrewOn = 2; }
        }
        if (!(cscrewOn == 0)) {
            if (transform.rotation.z > 0.7 & cscrewOn == 2)
            {
                NotTouching.score += 100;
                cscrewOn = 0;
                stuntName = "Corkscrew!";
            }
            if (transform.rotation.z < 0.3 & cscrewOn == 1)
            {
                NotTouching.score += 100;
                cscrewOn = 0;
                stuntName = "Corkscrew!";

            }
        }
    }
}
