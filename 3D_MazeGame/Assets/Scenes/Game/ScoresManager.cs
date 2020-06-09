using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresManager : MonoBehaviour
{
    public Text CoinsDisplay;
    public static ScoresManager instance;
    public int CoinsScore;

    void Start()
    {
        instance = this;

        //set all Scores
        CoinsScore = 0;
    }

    void Update()
    {
        CoinsDisplay.text = CoinsScore.ToString();
    }
}
