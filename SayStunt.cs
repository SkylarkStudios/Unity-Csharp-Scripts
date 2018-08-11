using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayStunt : MonoBehaviour {

    Text text;                      // Reference to the Text component.
    int on = 0;
    float time = 0;
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        text.text = "";
    }


    //void Update()
    //{
    // Set the displayed text to be the word "Score" followed by the score value.
    // text.text = "Score: " + score;
    //}

    // Update is called once per frame
    void Update()
    {
        text.text = StuntReader.stuntName;
        if (!(StuntReader.stuntName == "") & on == 0)
        {
            on = 1;
            time = 0;
            
        }
        else
        {
            text.text = "";
        }
        if (on == 1) {
            time += Time.deltaTime;
            print(time);
        }
 if (time > 30) { 
                time = 0;
                on = 0;
                StuntReader.stuntName = "";
            text.text = "";
            }
        print(time);
    }
}
