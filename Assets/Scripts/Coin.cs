using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // OnTriggerEnter
    // give the player a coin
    // destroy the object

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if(player != null)
        {
            player.AddCoins();
        }
        Destroy(gameObject);        
    }
}
