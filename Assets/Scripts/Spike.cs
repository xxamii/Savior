using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CatHealth>() && FindObjectOfType<GameState>().IsGameOn)
        {
            collision.GetComponent<CatHealth>().DealDamage();
        }
    }
}
