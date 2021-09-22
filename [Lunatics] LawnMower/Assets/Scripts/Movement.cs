using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Joystick joystick;

    void Update()
    {
        float hAxis = joystick.Horizontal;//x axis
        float vAxis = joystick.Vertical;//y axis
        float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;    
        print(zAxis); // 90 or -90
        
        transform.Rotate(0, 0, ((zAxis * Time.deltaTime) / -1) * 2);
        transform.position += transform.up * Time.deltaTime * 1f;
    }
}
