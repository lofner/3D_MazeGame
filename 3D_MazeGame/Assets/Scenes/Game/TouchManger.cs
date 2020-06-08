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
    public GameObject TopViewCameraObject;
    public Camera TopViewCamera;

    private float PlayerRotation;

    public float ZoomSpeed = 0.5f;
    public float FieldOfView_MIN = 0.1f;
    public float FieldOfView_MAX = 179.9f;

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
                //Top View Mode deaktive
                if(TopViewCameraObject.activeSelf == false)
                {
                    //save Player rotation
                    PlayerRotation = player.transform.rotation.y;

                    if (touch.position.x > Screen.width / 2)    //right side of display
                    {
                        //look around
                        player.transform.Rotate(0, touch.deltaPosition.x * PlayerRotationRate, 0, Space.World);
                    }
                }
                
                //Top View Mode aktive
                else if (TopViewCameraObject.activeSelf == true)
                {
                    Touch touchZero = Input.GetTouch(0);
                    Touch touchOne = Input.GetTouch(1);

                    Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                    Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                    float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                    float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                    float deltaMagnitudediff = prevTouchDeltaMag - touchDeltaMag;

                    TopViewCamera.fieldOfView += deltaMagnitudediff * ZoomSpeed;
                    TopViewCamera.fieldOfView = Mathf.Clamp(TopViewCamera.fieldOfView, FieldOfView_MIN, FieldOfView_MAX);

                }
            }
            /*
            else if(touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Touch Phase Ended");
            }
            */
        }

        if(TopViewCameraObject.activeSelf == false)
        {
            //JoyStick
            float moveVertical = joystick.Vertical;
            float moveHorizontal = joystick.Horizontal;

            Vector3 direction = player.transform.forward * joystick.Vertical + player.transform.right * joystick.Horizontal;
            player.transform.Translate(direction * PlayerSpeed * Time.deltaTime, Space.World);
        }
        
    }
}
