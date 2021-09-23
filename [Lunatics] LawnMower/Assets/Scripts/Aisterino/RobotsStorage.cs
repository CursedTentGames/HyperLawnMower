using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotsStorage : MonoBehaviour//Singleton
{
    [HideInInspector]
    public List<Robot> listOfRobots = new List<Robot>();//Change new List part after adding saving saving system

    public static RobotsStorage Instance;

    Robot firstRobot;
    Robot exampleRobot;
    Robot exampleRobot2;

    private void Awake()
    {
        Instance = this;

        #region Adding Robots to the List

        firstRobot = new Robot("firstRobot", .8f, 1.5f, 0, PriceTypes.Free);
        exampleRobot = new Robot("exampleRobot",  1, 2, 100, PriceTypes.Gold);
        exampleRobot2 = new Robot("exampleRobot2", 1.2f, 2, 500, PriceTypes.Gold);

        #endregion
    }

    private void Start()
    {
        Player.Instance.BuyRobot(firstRobot);
    }
}
