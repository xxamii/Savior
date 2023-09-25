using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameTrigger : MonoBehaviour
{
    [SerializeField] private GameState _gameState;
    [SerializeField] private RespawnManager _respawnManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Cat>() && _gameState.IsGameOn)
        {
            _gameState.StopGame();
            _respawnManager.ResetCheckPoints();
            collision.GetComponent<Cat>().EndGame();
        }
    }
}
