using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManger : MonoBehaviour
{

    //Player Movement
    public float PlayerRotationRate = 0.1f;
    public float PlayerSpeed = 10f;

    public GameObject player;
    public VariableJoystick joystick;

    //TopViewMode
    public GameObject TopViewCamera;

    private float PlayerRotation;

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            Debug.Log("Touching at: " + touch.position);
            /*
            if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch phase began at: " + touch.position);
            }
            */
            if (touch.phase == TouchPhase.Moved)
            {
                if (touch.position.x > Screen.width / 2 && TopViewCamera.activeSelf == false)
                {
                    //Debug.Log("Touch phase Moved");

                    PlayerRotation = player.transform.rotation.y;

                    player.transform.Rotate(0, touch.deltaPosition.x * PlayerRotationRate, 0, Space.World);
                }
            }
            /*
            else if(touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Touch Phase Ended");
            }
            */
        }

        //JoyStick
        float moveVertical = joystick.Vertical;
        float moveHorizontal = joystick.Horizontal;

        Vector3 direction = player.transform.forward * joystick.Vertical + player.transform.right * joystick.Horizontal;
        player.transform.Translate(direction * PlayerSpeed * Time.deltaTime, Space.World);
    }

}
