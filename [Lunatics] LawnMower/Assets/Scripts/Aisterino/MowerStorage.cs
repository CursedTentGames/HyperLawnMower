using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MowerStorage : MonoBehaviour//Singleton
{
    [HideInInspector]
    public List<Mower> listOfRobots = new List<Mower>();//Change new List part after adding saving saving system

    public static MowerStorage Instance;

    Mower firstMower;
    Mower exampleMower;
    Mower exampleMower2;

    private void Awake()
    {
        Instance = this;

        #region Adding Robots to the List

        firstMower = new Mower("firstRobot", .8f, 1.5f, 0, PriceTypes.Free);
        exampleMower = new Mower("exampleRobot",  1, 2, 100, PriceTypes.Gold);
        exampleMower2 = new Mower("exampleRobot2", 1.2f, 2, 500, PriceTypes.Gold);

        #endregion
    }

    private void Start()
    {
        Player.Instance.BuyMower(firstMower);
    }
}
