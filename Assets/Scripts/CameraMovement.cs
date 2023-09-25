using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameState _gameState;

    private RespawnManager _respawnManager;

    private Transform _transform;
    private float _speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        _respawnManager = FindObjectOfType<RespawnManager>();

        if (_respawnManager.CameraCheckpoint != Vector3.zero)
        {
            _transform.position = new Vector3(0, _respawnManager.CameraCheckpoint.y, -10);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _speed = 5f;
        }
        else
        {
            _speed = 3f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_gameState.IsGameOn)
        {
            _transform.Translate(Vector2.up * _speed * Time.fixedDeltaTime);
        }
    }
}
