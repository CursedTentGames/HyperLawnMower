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
        //print(zAxis); // 90 or -90 // I have commeneted out this line because I had to check how inventory system works, you can enable it again if you need
        
        transform.Rotate(0, 0, ((zAxis * Time.deltaTime) / -1) * Player.Instance.CurrentRobot.rotationSpeed); // Changed *2 to Player.Instance.CurrentRobot.rotationSpeed
        transform.position += transform.up * Time.deltaTime * Player.Instance.CurrentRobot.moveSpeed; //Changed *1 to  Player.Instance.CurrentRobot.moveSpeed
    }
}
