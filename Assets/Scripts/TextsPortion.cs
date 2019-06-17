using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextsPortion : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI story;
    [SerializeField] State startingState;
    [SerializeField] GameObject alert;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        story.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for(int i = 0; i < nextStates.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
            //if (state.GetName().Equals("Game Over"))
            //{
            //    if (Input.GetKeyDown(KeyCode.Q))
            //    {
            //        Application.Quit();
            //    }
            //}
        }


        //if (state.GetName().Equals("Game Over"))
        //{
        //    if (Input.GetKeyDown(KeyCode.Q))
        //    {
        //        Application.Quit();
        //    }
        //}

        story.text = state.GetStateStory();

    }
}
