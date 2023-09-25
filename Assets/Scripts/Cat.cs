using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private GameState _gameState;
    [SerializeField] private AudioClip _meowSound, _purrSound;

    private Transform _transform;
    private CatHealth _health;
    private Animator _animator;

    private RespawnManager _respawnManager;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _health = GetComponent<CatHealth>();
        _respawnManager = FindObjectOfType<RespawnManager>();
        _animator = _transform.parent.gameObject.GetComponent<Animator>();

        if (_respawnManager.CatCheckpoint != Vector3.zero)
        {
            _transform.position = _respawnManager.CatCheckpoint;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CatSeat catSeat = collision.gameObject.GetComponent<CatSeat>();
        if (catSeat)
        {
            if (!catSeat.Activated)
            {
                AudioSource.PlayClipAtPoint(_meowSound, Camera.main.transform.position, 0.5f);
                _transform.parent = collision.transform;
                collision.gameObject.GetComponent<CatSeat>().Activate();
                _transform.localPosition = new Vector3(0.526f, -0.6173f, 0);
                GetComponent<BoxCollider2D>().enabled = false;
                GetComponent<PolygonCollider2D>().enabled = true;
                _animator.SetBool("isHanging", true);
                _gameState.StartGame();
            }
        }
    }

    public void EndGame()
    {
        AudioSource.PlayClipAtPoint(_purrSound, Camera.main.transform.position);
    }
}
