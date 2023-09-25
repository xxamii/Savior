using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHealth : MonoBehaviour
{
    [SerializeField] private GameState _gameState;
    [SerializeField] private GameUI _gameUI;
    [SerializeField] private int _startAmount = 3;
    [SerializeField] private int _amount;
    [SerializeField] private CatSeat _catSeat;
    [SerializeField] private AudioClip _hurtSound, _angrySound;

    private Cat _cat;
    private Animator _animator;

    private float _timeBetweenDamage = 0.8f;

    public int Amount => _amount;

    private void Start()
    {
        _amount = _startAmount;
        _cat = GetComponent<Cat>();
        _animator = transform.parent.gameObject.GetComponent<Animator>();
    }

    public void DealDamage()
    {
        if (Time.time >= _timeBetweenDamage)
        {
            AudioSource.PlayClipAtPoint(_hurtSound, Camera.main.transform.position, 2f);
            _amount--;

            _gameUI.ShowLives(_amount);

            _animator.SetTrigger("Hurt");

            _timeBetweenDamage = Time.time + 0.8f;
        }

        if (_amount <= 0)
        {
            Lose();
        }
    }

    public void AddHealth()
    {
        if (_amount < 3)
        {
            _amount++;
            _gameUI.ShowLives(_amount);
        }
        
    }

    private void Lose()
    {
        AudioSource.PlayClipAtPoint(_angrySound, Camera.main.transform.position, 0.5f);
        _gameState.StopGame();
        _catSeat.Deactivate();
        transform.parent.parent = null;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<PolygonCollider2D>().enabled = false;
        this.gameObject.AddComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        _animator.SetBool("isHanging", false);
        transform.parent = null;
    }
}
