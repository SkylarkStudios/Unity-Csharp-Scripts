using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotTouching : MonoBehaviour {
    public int collisions = 0;
    public static float score = 0;
    public static float livePercent = 0;
    public static int lives = 3;
    float downTime = 0;
    Transform start;
    void OnCollisionEnter(Collision collision)
    {
        collisions++;
    }

    void OnCollisionExit(Collision collision)
    {
        collisions--;
    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if (lives > -1)
        {
            if (collisions == 0)
            {
                score += Time.deltaTime;
                //downTime = 0;
            }
            else
            {
                downTime += 5 * Time.deltaTime;
            }
            livePercent = downTime / 20 * 100;
            //print(100 - livePercent);
            //print(downTime);
           // print(Mathf.Round(100 - livePercent) < 1);
            if (100 - livePercent < 0.1)
            {
                transform.position = (new Vector3(32, 0, 285));
                transform.LookAt(new Vector3(32, 0, 284));
                downTime = 0;
                livePercent = 100;
                // score -= 100;
                
                lives--;
                print("done");
            }
        }
        if (transform.position.x > 4500) {
            transform.position = new Vector3(4500,transform.position.y,transform.position.z);
        }
        if (transform.position.z > 2500-250)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 2500-250);
        }
        if (transform.position.x < 500)
        {
            transform.position = new Vector3(500, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -2500+250)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -2500+250);
        }
    }

}

