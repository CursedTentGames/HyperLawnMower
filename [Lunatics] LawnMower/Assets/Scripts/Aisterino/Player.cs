using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour // Singleton
{
    public static Player Instance;

    private float gold = 0;
    private float gems = 0;

    private List<Robot> RobotsInventory = new List<Robot>();
    private Robot currentRobot;
    public Robot CurrentRobot { get { return currentRobot; } }

    private void Awake()
    {
        Instance = this;
    }

    public void BuyRobot(Robot robot)
    {
        switch(robot.PriceType)
        {
            case (PriceTypes.Free):
                RobotsInventory.Add(robot);
                break;
            case (PriceTypes.Gold):
                if(robot.Price <= gold)
                {
                    RobotsInventory.Add(robot);
                }
                else
                {
                    //warrning that player doesn't have enough gold
                }
                break;
            case (PriceTypes.Gems):
                if (robot.Price <= gems)
                {
                    RobotsInventory.Add(robot);
                }
                else
                {
                    //warrning that player doesn't have enough gems
                }
                break;
        }

        currentRobot = robot; // For testing only

        #region Testing Players Inventory
        /*
        if (RobotsInventory.Count > 0)//For testing only
        {
            Debug.Log("-------------------------");
            Debug.Log("List of robots in Players inventory");
            foreach (Robot robotInInv in RobotsInventory)
            {
                Debug.Log(robotInInv.name);
            }
            Debug.Log("-------------------------");
        }
        else
        {
            Debug.Log("List of Robots in Inventory is empty");
        }
        */
        #endregion
    }

    public float Gold
    {
        get
        {
            return gold;
        }
    }
}
