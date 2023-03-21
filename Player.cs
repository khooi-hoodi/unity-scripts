using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int _health;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    int power;
    string name;

    public Player(int health, int power, string name)
    {
        Health = health;
        this.power = power;
        this.name = name;
    }

    public void Attack()
    {
        Debug.Log(name + " is attacking");
    }

    public void Info()
    {
        Debug.Log("Health is " + _health);
        Debug.Log("Power is " + power);
        Debug.Log("Name is " + name);
    }

    // public void SetHealth(int health)
    // {
    //     this.health = health;
    // }

    // public int GetHealth()
    // {
    //     return health;
    // }
}
