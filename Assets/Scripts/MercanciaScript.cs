using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    bool collisionWithPlayer(Collision c)
    {
        return c.gameObject.name == "Player";
    }

    
}
