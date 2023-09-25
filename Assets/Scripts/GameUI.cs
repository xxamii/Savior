using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Sprite[] _livesSprites;
    [SerializeField] private Image _livesImage;

    public void ShowLives(int amount)
    {
        _livesImage.sprite = _livesSprites[amount];
    }
}
