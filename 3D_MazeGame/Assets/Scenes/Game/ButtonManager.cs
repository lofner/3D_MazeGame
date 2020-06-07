using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject player;
    public GameObject TopViewCamera;

    float PlayerRotation;

    void Update()
    {
        if (TopViewCamera.activeSelf == false)
        {
            PlayerRotation = player.transform.rotation.y;
        }
    }

    public void ToggleToTopView()
    {
        player.transform.rotation = Vector3(0, 0, 0);
    }

    public void ToggleToPlayerView()
    {
        player.transform.rotation = PlayerRotation;
    }
}
