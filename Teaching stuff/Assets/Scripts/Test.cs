using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("Hello world!");
        }

        int j = 0;

        while(j < 5)
        {
            Debug.Log("Hello world!");
            j++;
        }

        int switchTest = 0;

        switch(switchTest)
        {
            case (0):
                Debug.Log("0");
                break;
            case (1):
                Debug.Log("1");
                break;
            case (2):
                Debug.Log("2");
                break;
        }
        
    }
}
