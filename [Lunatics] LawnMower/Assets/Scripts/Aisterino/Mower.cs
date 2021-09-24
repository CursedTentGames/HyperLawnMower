using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mower
{
    public string name;
    public float rotationSpeed;
    public float moveSpeed;

    #region Price things
    private float price;
    public float Price { get { return price; } } //Other classes can only get the value of the price

    private PriceTypes priceType;
    public PriceTypes PriceType { get { return priceType; } }
    #endregion  

    public Mower(string name, float rotationSpeed, float moveSpeed, float price, PriceTypes priceType)
    {
        this.name = name;
        this.rotationSpeed = rotationSpeed;
        this.moveSpeed = moveSpeed;
        this.price = price;
        this.priceType = priceType;
    }
}

public enum PriceTypes
{
    Gold,
    Gems,
    Free
}
