using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour // Singleton
{
    public static Player Instance;

    private float gold = 0;
    private float gems = 0;

    private List<Mower> MowerInventory = new List<Mower>();
    private Mower currentMower;
    public Mower CurrentMower { get { return currentMower; } }

    private void Awake()
    {
        Instance = this;
    }

    public void BuyMower(Mower mower)
    {
        switch(mower.PriceType)
        {
            case (PriceTypes.Free):
                MowerInventory.Add(mower);
                break;
            case (PriceTypes.Gold):
                if(mower.Price <= gold)
                {
                    MowerInventory.Add(mower);
                }
                else
                {
                    //warrning that player doesn't have enough gold
                }
                break;
            case (PriceTypes.Gems):
                if (mower.Price <= gems)
                {
                    MowerInventory.Add(mower);
                }
                else
                {
                    //warrning that player doesn't have enough gems
                }
                break;
        }

        currentMower = mower; // For testing only

        #region Testing Players Inventory
        /*
        if (MowerInventory.Count > 0)//For testing only
        {
            Debug.Log("-------------------------");
            Debug.Log("List of mower in Players inventory");
            foreach (Mower mowerInInv in MowerInventory)
            {
                Debug.Log(mowerInInv.name);
            }
            Debug.Log("-------------------------");
        }
        else
        {
            Debug.Log("List of mowers in Inventory is empty");
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
