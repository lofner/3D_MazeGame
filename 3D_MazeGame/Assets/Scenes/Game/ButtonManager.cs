using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject player;
    public GameObject TopViewCameraObject;

    float PlayerRotation;

    void Update()
    {
        if (TopViewCameraObject.activeSelf == false)
        {
            PlayerRotation = player.transform.rotation.y;
        }
    }
    
    public void ToggleToTopView()
    {
        //player.transform.rotation = new Vector3(0, 0, 0);
    }

    public void ToggleToPlayerView()
    {
        //player.transform.rotation = PlayerRotation;
    }
}
