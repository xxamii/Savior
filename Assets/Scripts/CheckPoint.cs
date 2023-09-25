using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private AudioClip _activatedSound;

    private Transform _transform;
    private Animator _animator;
    private bool _isActivated = false;

    public bool IsActivated => _isActivated;

    private RespawnManager _respawnManager;

    private void Start()
    {
        _respawnManager = FindObjectOfType<RespawnManager>();
        _transform = this.transform;
        _animator = GetComponent<Animator>();
    }

    public void Activate()
    {
        AudioSource.PlayClipAtPoint(_activatedSound, Camera.main.transform.position);
        _animator.SetBool("Activated", true);
        _respawnManager.CatCheckpoint = _transform.position;
        _respawnManager.CameraCheckpoint = new Vector3(0, _transform.position.y + 2.3f, -10);
    }
}
