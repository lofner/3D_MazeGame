using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresManager : MonoBehaviour
{
    public static ScoresManager instance;

    public Text CoinsDisplay;
    
    public int CoinsScore;
    public int RoomsCounter;
    public int RoomsTemplatesSelectionPhase;

    void Start()
    {
        instance = this;

        //set all Scores (später über eine Datei - nicht jedes mal auf 0)
        CoinsScore = 0;
        RoomsCounter = 1;   //start room is already there
        RoomsTemplatesSelectionPhase = 0;
    }

    void Update()
    {
        //CoinsScore
        CoinsDisplay.text = CoinsScore.ToString();

        //RoomsCounter
        if (RoomsCounter <= 5)
        {
            RoomsTemplatesSelectionPhase = 0;
        }

        else if (RoomsCounter > 5 && RoomsCounter <= 10)
        {
            RoomsTemplatesSelectionPhase = 1;
        }

        else if (RoomsCounter > 10)
        {
            RoomsTemplatesSelectionPhase = 2;
        }
    }
}
