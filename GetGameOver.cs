using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetGameOver : MonoBehaviour {

    Text text;                      // Reference to the Text component.


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
        if (NotTouching.lives < 0) {
            text.text = "Game Over";
        } else { text.text = ""; }

    }
}
