using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showfps : MonoBehaviour
{
    public Text fps;
    private float fpsCalculation = 0.0f;

    void Update()
    {
        fpsCalculation = 1.0f / Time.deltaTime;
        fps.text = fpsCalculation.ToString();
    }
}
