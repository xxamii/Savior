using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverCanvas;

    private bool _isGameOn = false;

    public bool IsGameOn => _isGameOn;

    public void StartGame()
    {
        _isGameOn = true;
    }

    public void StopGame()
    {
        _isGameOn = false;
        _gameOverCanvas.SetActive(true);
    }
}
