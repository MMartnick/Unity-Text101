using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    // int and string array example
    int[] oddNumbers = {1, 3 , 5 , 7 , 9};
    string[] daysOfWeek = {"mon", "tues", "wens", "thurs"};

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(oddNumbers[3]);
        Debug.Log(daysOfWeek[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
