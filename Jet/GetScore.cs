using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        text.text = "hi";
    }


    //void Update()
    //{
    // Set the displayed text to be the word "Score" followed by the score value.
    // text.text = "Score: " + score;
    //}

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + (Mathf.Round(NotTouching.score));

    }
}
