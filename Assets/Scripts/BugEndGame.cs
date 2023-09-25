using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugEndGame : MonoBehaviour
{
    [SerializeField] private GameState _gameState;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Cat>())
        {
            _gameState.StopGame();
        }
    }
}
