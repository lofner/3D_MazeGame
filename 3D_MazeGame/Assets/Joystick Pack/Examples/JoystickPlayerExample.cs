using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    //public Rigidbody rb;

    public void Update()
    {
        float moveVertical = variableJoystick.Vertical;
        float moveHorizontal = variableJoystick.Horizontal;

        Vector3 direction = transform.forward * variableJoystick.Vertical + transform.right * variableJoystick.Horizontal;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}